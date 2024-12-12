using EUREKA_SOAP_DOTNET_CLIESC.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EUREKA_SOAP_DOTNET_CLIESC.View
{
    public partial class CuentaView : Form
    {
        public CuentaView()
        {
            InitializeComponent();
        }

        private async void btnProcesar_Click(object sender, EventArgs e)
        {
            string selectedTransaction = cbTransaccion.SelectedItem.ToString();

            // Obtener los valores de los campos de texto
            string cuenta = txtOrigen.Text;
            string monto = txtMonto.Text;
            string destino = txtDestino.Text;

            // Crear una instancia del controlador
            CuentaController controller = new CuentaController();

            // Determinar el tipo de transacción
            switch (selectedTransaction)
            {
                case "Depósito":
                    selectedTransaction = "DEP";
                    break;
                case "Retiro":
                    selectedTransaction = "RET";
                    break;
                case "Transferencia":
                    selectedTransaction = "TRA";
                    break;
                default:
                    // Puede agregar un caso por defecto si es necesario
                    break;
            }

            await controller.PerformTransaction(cuenta, monto, selectedTransaction, destino, this);
        }
    }
}
