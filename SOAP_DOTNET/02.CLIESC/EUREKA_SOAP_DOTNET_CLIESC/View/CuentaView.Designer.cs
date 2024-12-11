using System;
using System.Windows.Forms;

namespace EUREKA_SOAP_DOTNET_CLIESC.View
{
    partial class CuentaView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayMessage = new System.Windows.Forms.Label();
            this.lblCtaOrigen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cbTransaccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblCtaDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EUREKA_SOAP_DOTNET_CLIESC.Properties.Resources.oozma;
            this.pictureBox1.Location = new System.Drawing.Point(215, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCtaDestino);
            this.panel1.Controls.Add(this.txtDestino);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.cbTransaccion);
            this.panel1.Controls.Add(this.displayMessage);
            this.panel1.Controls.Add(this.lblCtaOrigen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtOrigen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnProcesar);
            this.panel1.Location = new System.Drawing.Point(195, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 396);
            this.panel1.TabIndex = 10;
            // 
            // displayMessage
            // 
            this.displayMessage.AutoSize = true;
            this.displayMessage.Location = new System.Drawing.Point(84, 427);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(35, 13);
            this.displayMessage.TabIndex = 8;
            this.displayMessage.Text = "label4";
            // 
            // lblCtaOrigen
            // 
            this.lblCtaOrigen.AutoSize = true;
            this.lblCtaOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblCtaOrigen.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblCtaOrigen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCtaOrigen.Location = new System.Drawing.Point(41, 102);
            this.lblCtaOrigen.Name = "lblCtaOrigen";
            this.lblCtaOrigen.Size = new System.Drawing.Size(102, 31);
            this.lblCtaOrigen.TabIndex = 4;
            this.lblCtaOrigen.Text = "Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(93, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transacciones";
            // 
            // txtOrigen
            // 
            this.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigen.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(47, 136);
            this.txtOrigen.MinimumSize = new System.Drawing.Size(17, 20);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(290, 37);
            this.txtOrigen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProcesar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(87, 337);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(228, 43);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // cbTransaccion
            // 
            this.cbTransaccion.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransaccion.FormattingEnabled = true;
            this.cbTransaccion.Location = new System.Drawing.Point(113, 61);
            this.cbTransaccion.Name = "cbTransaccion";
            this.cbTransaccion.Size = new System.Drawing.Size(224, 31);
            this.cbTransaccion.TabIndex = 9;
            this.cbTransaccion.Items.AddRange(new string[] { "Depósito", "Retiro", "Transferencia" });
            this.cbTransaccion.SelectedIndexChanged += new System.EventHandler(this.cbTransaccion_SelectedIndexChanged);

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(41, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(47, 220);
            this.txtMonto.MinimumSize = new System.Drawing.Size(17, 20);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(290, 37);
            this.txtMonto.TabIndex = 10;
            // 
            // lblCtaDestino
            // 
            this.lblCtaDestino.AutoSize = true;
            this.lblCtaDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblCtaDestino.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblCtaDestino.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCtaDestino.Location = new System.Drawing.Point(41, 260);
            this.lblCtaDestino.Name = "lblCtaDestino";
            this.lblCtaDestino.Size = new System.Drawing.Size(198, 31);
            this.lblCtaDestino.TabIndex = 13;
            this.lblCtaDestino.Text = "Cuenta Destino";
            // 
            // txtDestino
            // 
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestino.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(47, 294);
            this.txtDestino.MinimumSize = new System.Drawing.Size(17, 20);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(290, 37);
            this.txtDestino.TabIndex = 12;
            // 
            // CuentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EUREKA_SOAP_DOTNET_CLIESC.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(791, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CuentaView";
            this.Text = "CuentaView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label displayMessage;
        private System.Windows.Forms.Label lblCtaOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblCtaDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cbTransaccion;

        private void cbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar la selección del ComboBox
            if (cbTransaccion.SelectedItem.ToString() == "Depósito" || cbTransaccion.SelectedItem.ToString() == "Retiro")
            {
                // Cuando sea Depósito o Retiro
                lblCtaOrigen.Text = "Número de cuenta";  // Cambiar texto de la cuenta de origen
                lblCtaDestino.Visible = false;  // Ocultar cuenta destino
                txtDestino.Visible = false;  // Ocultar campo de cuenta destino
            }
            else if (cbTransaccion.SelectedItem.ToString() == "Transferencia")
            {
                // Cuando sea Transferencia
                lblCtaOrigen.Text = "Cuenta Orígen";  // Cambiar texto de la cuenta de origen
                lblCtaDestino.Visible = true;  // Mostrar cuenta destino
                txtDestino.Visible = true;  // Mostrar campo de cuenta destino
            }
        }

    }
}