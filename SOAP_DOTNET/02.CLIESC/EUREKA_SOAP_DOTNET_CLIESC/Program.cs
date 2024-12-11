using EUREKA_SOAP_DOTNET_CLIESC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EUREKA_SOAP_DOTNET_CLIESC.Controller;

namespace EUREKA_SOAP_DOTNET_CLIESC
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static async Task Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginView());
            //var controller = new Controller();
            //await controller.RunAsync();
        }
    }
}
