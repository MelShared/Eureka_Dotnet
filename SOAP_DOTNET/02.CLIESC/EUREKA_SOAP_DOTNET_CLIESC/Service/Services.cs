using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUREKA_SOAP_DOTNET_CLIESC.Service
{
    public class Services
    {
        private LoginReference.LoginServiceClient _loginService;
        private CuentaReference.CuentaServiceClient _cuentaService;
        private MoviReference.MovimientoServiceClient _movimientoService;

        public Services()
        {
            _loginService = new LoginReference.LoginServiceClient();
            _cuentaService = new CuentaReference.CuentaServiceClient();
            _movimientoService = new MoviReference.MovimientoServiceClient();
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            return await _loginService.LoginAsync(username, password);
        }

        public async Task<bool> PerformTransactionAsync(string accountCode, string amount, string transactionType, string destinationAccount = null)
        {
            string type;

            switch (transactionType.ToLower())
            {
                case "dep":
                    type = "DEP";
                    break;
                case "ret":
                    type = "RET";
                    break;
                case "tra":
                    type = "TRA";
                    break;
                default:
                    throw new ArgumentException("Invalid transaction type");
            }

            return await _cuentaService.ActualizarSaldoYRegistrarMovimientoAsync(
                accountCode,
                amount,
                type,
                destinationAccount ?? ""
            );
        }


        public async Task<MoviReference.CustomMovimientoModel[]> GetAccountMovementsAsync(string accountCode)
        {
            return await _movimientoService.ObtenerMovimientosPorCuentaAsync(accountCode);
        }
    }
}
