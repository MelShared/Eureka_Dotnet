using EUREKA_SOAP_DOTNET_CLIESC.Service;

using EUREKA_SOAP_DOTNET_CLIESC.View;

using System;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace EUREKA_SOAP_DOTNET_CLIESC.Controller

{

    public class CuentaController

    {

        private Services _service;



        public CuentaController()

        {

            _service = new Services();

        }



        public async Task PerformTransaction(string cuenta, string monto, string tipo, string cd, CuentaView cuentaView)

        {
            bool success = await _service.PerformTransactionAsync(cuenta, monto, tipo, cd);

            if (success)

            {
                MessageBox.Show("Proceso exitoso");
            }

            else
            {
                MessageBox.Show("Transaction failed.");
            }

        }

    }

}