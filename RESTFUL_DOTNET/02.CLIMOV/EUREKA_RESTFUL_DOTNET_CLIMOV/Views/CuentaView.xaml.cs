using EUREKA_RESTFUL_DOTNET_CLIMOV.Controller;
using EUREKA_RESTFUL_DOTNET_CLIMOV;
using EUREKA_RESTFUL_DOTNET_CLIMOV.Model;
namespace EUREKA_RESTFUL_DOTNET_CLIMOV.Views;

public partial class CuentaView : ContentPage
{
    private string _operationType = "DEP";
	private MovimientosController MovimientosController;
    public CuentaView()
	{
		InitializeComponent();

        MovimientosController = new MovimientosController();
        OperationPicker.SelectedIndexChanged += OnOperationPickerSelectedIndexChanged;
    }
    private void OnOperationPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        if (OperationPicker.SelectedIndex == -1) return;

        // Update the UI based on the selected operation
        string selectedOperation = OperationPicker.SelectedItem.ToString();
        switch (selectedOperation)
        {
            case "Dep�sito":
                _operationType = "DEP";
                AmountEntry.Placeholder = "Monto";
                DestinationAccountEntry.IsVisible = false;
                break;
            case "Retiro":
                _operationType = "RET";
                AmountEntry.Placeholder = "Monto a Retirar";
                DestinationAccountEntry.IsVisible = false;
                break;
            case "Transferencia":
                _operationType = "TRA";
                AmountEntry.Placeholder = "Monto a Transferir";
                DestinationAccountEntry.IsVisible = true;
                break;
        }
    }

    private async Task ShowCustomAlert(string title, string message)
    {
        await Navigation.PushModalAsync(new CustomAlert(title, message));
    }


    private async void OnProcessButtonClicked(object sender, EventArgs e)
    {
        string account = AccountEntry.Text?.Trim();
        string amountText = AmountEntry.Text?.Trim();
        string destinationAccount = DestinationAccountEntry.Text?.Trim();

        if (string.IsNullOrEmpty(account))
        {
            await ShowCustomAlert("Error", "Por favor ingrese un n�mero de cuenta");
            return;
        }

        if (string.IsNullOrEmpty(amountText) || !decimal.TryParse(amountText, out decimal amount) || amount <= 0)
        {
            await ShowCustomAlert("Error", "Ingrese un monto v�lido");
            return;
        }

        if (_operationType == "TRA" && string.IsNullOrEmpty(destinationAccount))
        {
            await ShowCustomAlert("Error", "Por favor ingrese la cuenta destino");
            return;
        }

        // Process the operation
        try
        {
            MovimientoRequest model = new MovimientoRequest
            {
                CodigoCuenta = account,
                ValorMovimiento = amount.ToString(),
                Tipo = _operationType,
                CuentaDest = destinationAccount
            };

            bool result = await MovimientosController.CrearMovimientoAsync(model);

            string message = result ? "Operaci�n exitosa" : "Operaci�n fallida";
            await ShowCustomAlert("Resultado", message);

            if (result)
            {
                // Optionally navigate back or reset fields
                OnCancelButtonClicked(sender, e);
            }
        }
        catch (Exception ex)
        {
            await ShowCustomAlert("Error", $"Error al procesar la operaci�n: {ex.Message}");
        }
    }

    private async void OnCancelButtonClicked(object sender, EventArgs e)
    {
        // Reset fields
        OperationPicker.SelectedIndex = -1;
        AccountEntry.Text = string.Empty;
        AmountEntry.Text = string.Empty;
        DestinationAccountEntry.Text = string.Empty;
        DestinationAccountEntry.IsVisible = false;

        // Optionally navigate back
        await Navigation.PopAsync();
    }
}