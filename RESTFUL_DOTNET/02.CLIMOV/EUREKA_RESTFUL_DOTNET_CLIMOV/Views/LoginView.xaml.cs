using EUREKA_RESTFUL_DOTNET_CLIMOV.Controller;
using EUREKA_RESTFUL_DOTNET_CLIMOV.Model;
namespace EUREKA_RESTFUL_DOTNET_CLIMOV.Views;

public partial class LoginView : ContentPage
{
	private readonly LoginController _loginController;

    public LoginView()
	{
		InitializeComponent();
		_loginController = new LoginController();
	}

    private async Task ShowCustomAlert(string title, string message)
    {
        await Navigation.PushModalAsync(new CustomAlert(title, message));
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text?.Trim();
        string password = PasswordEntry.Text?.Trim();

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            await ShowCustomAlert("Error", "Por favor, ingrese tanto el usuario como la contraseña");
            return;
        }

        LoginViewModel model = new LoginViewModel
        {
            Username = username,
            Password = password
        };


        var result = await _loginController.LoginAsync(model);


        if (result)
        {
            await ShowCustomAlert("Éxito", "Login exitoso");
            await Navigation.PushAsync(new NavigationPage(new MovimientoView()));
        }
        else
        {
            await ShowCustomAlert("Error", "Error en el login");
        }
    }
}