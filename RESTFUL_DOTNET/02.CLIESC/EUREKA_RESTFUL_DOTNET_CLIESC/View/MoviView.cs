using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EUREKA_SOAP_DOTNET_CLIESC.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EUREKA_SOAP_DOTNET_CLIESC.View
{
    public partial class MoviView : Form
    {
        public MoviView()
        {
            InitializeComponent();
        }

        private void CrearCeldasDinamicas()
        {
            // Simulamos algunos datos para las tarjetas
            string[] cuentas = { "12345", "67890", "11223" };
            string[] fechas = { "01/01/2024", "02/01/2024", "03/01/2024" };
            string[] movimientos = { "Depósito", "Retiro", "Transferencia" };
            string[] descripciones = { "Depósito de $100", "Retiro de $50", "Transferencia a cuenta 67890" };
            string[] tipos = { "Ingreso", "Egreso", "Ingreso" };
            string[] importes = { "$100", "$50", "$200" };

            // Agregamos celdas (tarjetas) al FlowLayoutPanel
            for (int i = 0; i < cuentas.Length; i++)
            {
                Panel celda = CrearCelda(cuentas[i], fechas[i], movimientos[i], descripciones[i], tipos[i], importes[i]);
                this.movLayoutPanel.Controls.Add(celda);  // Agregar cada celda al FlowLayoutPanel
            }
        }

        private Panel CrearCelda(string cuenta, string fecha, string movimiento, string descripcion, string tipo, string importe)
        {
            Panel panelCelda = new Panel
            {
                BackgroundImageLayout = ImageLayout.None,
                Size = new Size(550, 150),  // Ajusta el tamaño de las celdas según sea necesario
                BackColor = Color.FromArgb(214, 209, 246),  // Color de fondo de la celda
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                Margin = new Padding(10)  // Ajusta los márgenes si es necesario
            };

            // Etiquetas de texto
            Label labelCuenta = new Label
            {
                Text = cuenta,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            Label labelFecha = new Label
            {
                Text = fecha,
                Font = new Font("Arial", 10)
            };
            Label labelMovimiento = new Label
            {
                Text = movimiento,
                Font = new Font("Arial", 10)
            };
            Label labelDescripcion = new Label
            {
                Text = descripcion,
                Font = new Font("Arial", 10)
            };
            Label labelTipo = new Label
            {
                Text = tipo,
                Font = new Font("Arial", 10)
            };
            Label labelImporte = new Label
            {
                Text = importe,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 150, 255)
            };

            // Panel para organizar las etiquetas
            FlowLayoutPanel datosPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                BackColor = Color.FromArgb(214, 209, 246)
            };

            // Agregar las etiquetas al panel
            datosPanel.Controls.Add(labelCuenta);
            datosPanel.Controls.Add(labelFecha);
            datosPanel.Controls.Add(labelMovimiento);
            datosPanel.Controls.Add(labelDescripcion);
            datosPanel.Controls.Add(labelTipo);
            datosPanel.Controls.Add(labelImporte);

            // Agregamos el panel de datos a la celda
            panelCelda.Controls.Add(datosPanel);

            return panelCelda;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string cuenta = txtCuenta.Text;

            if (string.IsNullOrWhiteSpace(cuenta))
            {
                MessageBox.Show("Por favor, ingrese un número de cuenta válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MoviController controller = new MoviController();
            await controller.CheckMovements(cuenta, this);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            CuentaView deposito = new CuentaView();
            deposito.Show();
        }
    }
}
