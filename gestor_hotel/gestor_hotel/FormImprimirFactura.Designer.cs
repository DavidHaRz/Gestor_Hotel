namespace gestor_hotel
{
    partial class FormImprimirFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImprimirFactura));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnImprimirFactura = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.cboActualizarEstado = new System.Windows.Forms.ComboBox();
            this.lblActualizarEstado = new System.Windows.Forms.Label();
            this.cboMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.lblCantidadPagada = new System.Windows.Forms.Label();
            this.txtCantidadPagada = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(825, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 29);
            this.btnCerrar.TabIndex = 65;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirFactura.BackColor = System.Drawing.Color.SkyBlue;
            this.btnImprimirFactura.FlatAppearance.BorderSize = 0;
            this.btnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirFactura.Location = new System.Drawing.Point(519, 588);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Size = new System.Drawing.Size(183, 47);
            this.btnImprimirFactura.TabIndex = 143;
            this.btnImprimirFactura.Text = "Imprimir Factura";
            this.btnImprimirFactura.UseVisualStyleBackColor = false;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetroceder.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRetroceder.FlatAppearance.BorderSize = 0;
            this.btnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.Location = new System.Drawing.Point(127, 588);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(183, 47);
            this.btnRetroceder.TabIndex = 144;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // cboActualizarEstado
            // 
            this.cboActualizarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActualizarEstado.FormattingEnabled = true;
            this.cboActualizarEstado.Items.AddRange(new object[] {
            "Pagada",
            "Parcial",
            "Pendiente"});
            this.cboActualizarEstado.Location = new System.Drawing.Point(91, 441);
            this.cboActualizarEstado.Name = "cboActualizarEstado";
            this.cboActualizarEstado.Size = new System.Drawing.Size(263, 39);
            this.cboActualizarEstado.TabIndex = 147;
            this.cboActualizarEstado.SelectedIndexChanged += new System.EventHandler(this.cboActualizarEstado_SelectedIndexChanged);
            // 
            // lblActualizarEstado
            // 
            this.lblActualizarEstado.AutoSize = true;
            this.lblActualizarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarEstado.Location = new System.Drawing.Point(104, 406);
            this.lblActualizarEstado.Name = "lblActualizarEstado";
            this.lblActualizarEstado.Size = new System.Drawing.Size(236, 32);
            this.lblActualizarEstado.TabIndex = 146;
            this.lblActualizarEstado.Text = "Actualizar Estado";
            // 
            // cboMetodoPago
            // 
            this.cboMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetodoPago.FormattingEnabled = true;
            this.cboMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de credito",
            "Tarjeta de debito",
            "Bizum"});
            this.cboMetodoPago.Location = new System.Drawing.Point(477, 441);
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Size = new System.Drawing.Size(263, 39);
            this.cboMetodoPago.TabIndex = 149;
            this.cboMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cboMetodoPago_SelectedIndexChanged);
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(503, 406);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(219, 32);
            this.lblMetodoPago.TabIndex = 148;
            this.lblMetodoPago.Text = "Método de pago";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(144, 247);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(166, 32);
            this.lblPrecioTotal.TabIndex = 151;
            this.lblPrecioTotal.Text = "Precio Total";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioTotal.Enabled = false;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(140, 282);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(174, 38);
            this.txtPrecioTotal.TabIndex = 150;
            // 
            // lblCantidadPagada
            // 
            this.lblCantidadPagada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadPagada.AutoSize = true;
            this.lblCantidadPagada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPagada.Location = new System.Drawing.Point(487, 247);
            this.lblCantidadPagada.Name = "lblCantidadPagada";
            this.lblCantidadPagada.Size = new System.Drawing.Size(235, 32);
            this.lblCantidadPagada.TabIndex = 153;
            this.lblCantidadPagada.Text = "Cantidad Pagada";
            // 
            // txtCantidadPagada
            // 
            this.txtCantidadPagada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidadPagada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadPagada.Location = new System.Drawing.Point(519, 282);
            this.txtCantidadPagada.Name = "txtCantidadPagada";
            this.txtCantidadPagada.Size = new System.Drawing.Size(174, 38);
            this.txtCantidadPagada.TabIndex = 152;
            this.txtCantidadPagada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadPagada_KeyPress);
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(325, 107);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(217, 32);
            this.lblNumeroFactura.TabIndex = 155;
            this.lblNumeroFactura.Text = "Número Factura";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroFactura.Enabled = false;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(340, 142);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(174, 38);
            this.txtNumeroFactura.TabIndex = 154;
            // 
            // FormImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(871, 704);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.lblCantidadPagada);
            this.Controls.Add(this.txtCantidadPagada);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.cboMetodoPago);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.cboActualizarEstado);
            this.Controls.Add(this.lblActualizarEstado);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnImprimirFactura);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImprimirFactura";
            this.Text = "FormImprimirFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnImprimirFactura;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.ComboBox cboActualizarEstado;
        private System.Windows.Forms.Label lblActualizarEstado;
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Label lblCantidadPagada;
        private System.Windows.Forms.TextBox txtCantidadPagada;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
    }
}