using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EUREKA_SOAP_DOTNET_CLIESC.Service;
using EUREKA_SOAP_DOTNET_CLIESC.View;

namespace EUREKA_SOAP_DOTNET_CLIESC.Controller
{
    public class MoviController
    {
        private Services _service;

        public MoviController()
        {
            _service = new Services();
        }

        public async Task CheckMovements(string cuenta, MoviView movimientoView)
        {
            // Clear existing controls
            movimientoView.movLayoutPanel.Controls.Clear();

            var movements = await _service.GetAccountMovementsAsync(cuenta);

            foreach (var movement in movements)
            {
                Console.WriteLine(movement);
                var cell = CreateMovementCell(movement);

                movimientoView.movLayoutPanel.Controls.Add(cell);
            }
        }

        private Panel CreateMovementCell(MoviReference.CustomMovimientoModel movement)
        {
            Panel movementPanel = new Panel
            {
                BackColor = Color.FromArgb(214, 209, 246),
                Size = new Size(550, 150),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                Margin = new Padding(10)
            };

            string typeText = GetMovementTypeText(movement.CodigoTipoMovimiento);

            Label labelMovimiento = new Label
            {
                Text = $"Movimiento: {movement.NumeroMovimiento}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true
            };
            Label labelFecha = new Label
            {
                Text = $"Fecha: {movement.FechaMovimiento.ToString("yyyy-MM-dd")}",
                Font = new Font("Arial", 10),
                AutoSize = true
            };
            Label labelEmpleado = new Label
            {
                Text = $"Empleado: {movement.CodigoEmpleado}",
                Font = new Font("Arial", 10),
                AutoSize = true
            };
            Label labelTipo = new Label
            {
                Text = $"Tipo: {typeText}",
                Font = new Font("Arial", 10),
                AutoSize = true
            };
            Label labelImporte = new Label
            {
                Text = $"Importe: {movement.ImporteMovimiento.ToString("C")}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 150, 255),
                AutoSize = true
            };

            movementPanel.Controls.Add(labelMovimiento);
            movementPanel.Controls.Add(labelFecha);
            movementPanel.Controls.Add(labelEmpleado);
            movementPanel.Controls.Add(labelTipo);
            movementPanel.Controls.Add(labelImporte);

            // Arrange labels vertically
            labelMovimiento.Location = new Point(10, 10);
            labelFecha.Location = new Point(10, 40);
            labelEmpleado.Location = new Point(10, 70);
            labelTipo.Location = new Point(10, 100);
            labelImporte.Location = new Point(10, 130);

            return movementPanel;
        }

        private string GetMovementTypeText(string codigoTipoMovimiento)
        {
            switch (codigoTipoMovimiento)
            {
                case "003":
                    return "DEPOSITO";
                case "001":
                    return "CREACIÓN DE CUENTA";
                case "004":
                    return "RETIRO";
                case "008":
                    return "TRANSFERENCIA INGRESO";
                case "009":
                    return "TRANSFERENCIA SALIDA";
                default:
                    return codigoTipoMovimiento;
            }
        }
    }
}