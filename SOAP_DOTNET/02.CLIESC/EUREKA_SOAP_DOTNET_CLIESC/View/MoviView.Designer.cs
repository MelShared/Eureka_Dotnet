using System.Windows.Forms;

namespace EUREKA_SOAP_DOTNET_CLIESC.View
{
    partial class MoviView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jPanel1 = new System.Windows.Forms.Panel();
            this.movLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.displayMessage = new System.Windows.Forms.Label();
            this.jPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDepositar.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.btnDepositar.ForeColor = System.Drawing.Color.White;
            this.btnDepositar.Location = new System.Drawing.Point(480, 540);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(160, 40);
            this.btnDepositar.TabIndex = 3;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(480, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCuenta
            // 
            this.txtCuenta.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.txtCuenta.Location = new System.Drawing.Point(190, 30);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(260, 41);
            this.txtCuenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimientos";
            // 
            // jPanel1
            // 
            this.jPanel1.BackColor = System.Drawing.Color.White;
            this.jPanel1.Controls.Add(this.movLayoutPanel);
            this.jPanel1.Location = new System.Drawing.Point(50, 100);
            this.jPanel1.Name = "jPanel1";
            this.jPanel1.Size = new System.Drawing.Size(600, 430);
            this.jPanel1.TabIndex = 4;
            // 
            // movLayoutPanel
            // 
            this.movLayoutPanel.AutoScroll = true;
            this.movLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.movLayoutPanel.Location = new System.Drawing.Point(17, 22);
            this.movLayoutPanel.Name = "movLayoutPanel";
            this.movLayoutPanel.Size = new System.Drawing.Size(583, 392);
            this.movLayoutPanel.TabIndex = 0;
            // 
            // displayMessage
            // 
            this.displayMessage.AutoSize = true;
            this.displayMessage.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Italic);
            this.displayMessage.Location = new System.Drawing.Point(200, 60);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(0, 27);
            this.displayMessage.TabIndex = 5;
            // 
            // MoviView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::EUREKA_SOAP_DOTNET_CLIESC.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(797, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.jPanel1);
            this.Controls.Add(this.displayMessage);
            this.DoubleBuffered = true;
            this.Name = "MoviView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.jPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label displayMessage;
        private TextBox txtCuenta;
        private Button btnBuscar;
        private Button btnDepositar;
        private Panel jPanel1;
        public FlowLayoutPanel movLayoutPanel;
    }
}