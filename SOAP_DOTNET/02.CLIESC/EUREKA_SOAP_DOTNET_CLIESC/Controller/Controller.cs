using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using EUREKA_SOAP_DOTNET_CLIESC.Model;
using EUREKA_SOAP_DOTNET_CLIESC.Service;
using EUREKA_SOAP_DOTNET_CLIESC.View;


namespace EUREKA_SOAP_DOTNET_CLIESC.Controller
{
    public class LoginController
    {
        private Services _service;
        private LoginView _loginView;
        private MoviView _movimientoView;

        public LoginController(LoginView loginView)
        {
            _service = new Services();
            _loginView = loginView;
            _movimientoView = new MoviView();
        }

        public async Task<bool> IniciarSesionAsync(string username, string password)
        {
            try
            {
                string hashedPassword = HashPassword(password);
                if (await _service.LoginAsync(username, hashedPassword))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error en la autenticación: {ex.Message}");
            }
            return false;
        }

        public async Task AutenticarAsync(string username, string password)
        {
            if (await IniciarSesionAsync(username, password))
            {
                _loginView.Hide();
                _movimientoView.Show();
            }
            else
            {
                _loginView.displayMessage.Text = ("Usuario o contraseña inválidos.");
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //private async Task PerformTransaction(string transactionType)
        //{
        //    // Get the account code for the transaction
        //    string accountCode = _view.GetAccountCode(transactionType);

        //    // Get the transaction amount
        //    double amount = _view.GetAmount(transactionType);

        //    // Get destination account for transfers
        //    string destinationAccount = transactionType == "TRA"
        //        ? _view.GetDestinationAccount()
        //        : null;

        //    // Perform the transaction
        //    bool success = await _service.PerformTransactionAsync(
        //        accountCode,
        //        amount,
        //        transactionType,
        //        destinationAccount
        //    );

        //    if (success)
        //    {
        //        _view.DisplayMessage($"{char.ToUpper(transactionType[0]) + transactionType.Substring(1)} successful!");
        //    }
        //    else
        //    {
        //        _view.DisplayMessage("Transaction failed.", true);
        //    }
        //}

        //private async Task CheckMovements()
        //{
        //    // Get the account code for checking movements
        //    string accountCode = _view.GetAccountCode("checking movements");

        //    // Retrieve and display movements for the specified account
        //    var movements = await _service.GetAccountMovementsAsync(accountCode);
        //    _view.DisplayMovements(movements);
        //}
    }
}
