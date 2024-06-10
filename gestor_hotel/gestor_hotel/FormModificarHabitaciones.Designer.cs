namespace gestor_hotel
{
    partial class FormModificarHabitaciones
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNumeroPersonas = new System.Windows.Forms.Label();
            this.txtNumeroPersonas = new System.Windows.Forms.TextBox();
            this.lblNumeroHabitacion = new System.Windows.Forms.Label();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.lblIdHabitacion = new System.Windows.Forms.Label();
            this.txtIdHabitacion = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblActualizarEstado = new System.Windows.Forms.Label();
            this.cboActualizarEstado = new System.Windows.Forms.ComboBox();
            this.lblEstadoActual = new System.Windows.Forms.Label();
            this.txtEstadoActual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(157, 597);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 40);
            this.btnCancelar.TabIndex = 141;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.Lime;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(533, 597);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 40);
            this.btnAceptar.TabIndex = 140;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNumeroPersonas
            // 
            this.lblNumeroPersonas.AutoSize = true;
            this.lblNumeroPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPersonas.Location = new System.Drawing.Point(94, 273);
            this.lblNumeroPersonas.Name = "lblNumeroPersonas";
            this.lblNumeroPersonas.Size = new System.Drawing.Size(277, 32);
            this.lblNumeroPersonas.TabIndex = 133;
            this.lblNumeroPersonas.Text = "Número de personas";
            // 
            // txtNumeroPersonas
            // 
            this.txtNumeroPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPersonas.Location = new System.Drawing.Point(143, 311);
            this.txtNumeroPersonas.Name = "txtNumeroPersonas";
            this.txtNumeroPersonas.Size = new System.Drawing.Size(171, 38);
            this.txtNumeroPersonas.TabIndex = 132;
            this.txtNumeroPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPersonas_KeyPress);
            // 
            // lblNumeroHabitacion
            // 
            this.lblNumeroHabitacion.AutoSize = true;
            this.lblNumeroHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroHabitacion.Location = new System.Drawing.Point(447, 118);
            this.lblNumeroHabitacion.Name = "lblNumeroHabitacion";
            this.lblNumeroHabitacion.Size = new System.Drawing.Size(292, 32);
            this.lblNumeroHabitacion.TabIndex = 131;
            this.lblNumeroHabitacion.Text = "Número de habitación";
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.Enabled = false;
            this.txtNumeroHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(492, 153);
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(198, 38);
            this.txtNumeroHabitacion.TabIndex = 130;
            // 
            // lblIdHabitacion
            // 
            this.lblIdHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdHabitacion.AutoSize = true;
            this.lblIdHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdHabitacion.Location = new System.Drawing.Point(130, 115);
            this.lblIdHabitacion.Name = "lblIdHabitacion";
            this.lblIdHabitacion.Size = new System.Drawing.Size(184, 32);
            this.lblIdHabitacion.TabIndex = 128;
            this.lblIdHabitacion.Text = "ID Habitacion";
            // 
            // txtIdHabitacion
            // 
            this.txtIdHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdHabitacion.Enabled = false;
            this.txtIdHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHabitacion.Location = new System.Drawing.Point(136, 153);
            this.txtIdHabitacion.Name = "txtIdHabitacion";
            this.txtIdHabitacion.Size = new System.Drawing.Size(174, 38);
            this.txtIdHabitacion.TabIndex = 127;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(510, 273);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(157, 32);
            this.lbPrecio.TabIndex = 126;
            this.lbPrecio.Text = "Precio en €";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(523, 311);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(134, 38);
            this.txtPrecio.TabIndex = 125;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
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
            this.btnCerrar.TabIndex = 124;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(68, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(356, 42);
            this.lblTitulo.TabIndex = 123;
            this.lblTitulo.Text = "Modificar Habitación";
            // 
            // lblActualizarEstado
            // 
            this.lblActualizarEstado.AutoSize = true;
            this.lblActualizarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarEstado.Location = new System.Drawing.Point(119, 438);
            this.lblActualizarEstado.Name = "lblActualizarEstado";
            this.lblActualizarEstado.Size = new System.Drawing.Size(236, 32);
            this.lblActualizarEstado.TabIndex = 143;
            this.lblActualizarEstado.Text = "Actualizar Estado";
            // 
            // cboActualizarEstado
            // 
            this.cboActualizarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActualizarEstado.FormattingEnabled = true;
            this.cboActualizarEstado.Items.AddRange(new object[] {
            "libre",
            "bloqueada"});
            this.cboActualizarEstado.Location = new System.Drawing.Point(108, 473);
            this.cboActualizarEstado.Name = "cboActualizarEstado";
            this.cboActualizarEstado.Size = new System.Drawing.Size(263, 39);
            this.cboActualizarEstado.TabIndex = 145;
            this.cboActualizarEstado.SelectedIndexChanged += new System.EventHandler(this.cboActualizarEstado_SelectedIndexChanged);
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.AutoSize = true;
            this.lblEstadoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoActual.Location = new System.Drawing.Point(510, 438);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(187, 32);
            this.lblEstadoActual.TabIndex = 147;
            this.lblEstadoActual.Text = "Estado actual";
            // 
            // txtEstadoActual
            // 
            this.txtEstadoActual.Enabled = false;
            this.txtEstadoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoActual.Location = new System.Drawing.Point(516, 474);
            this.txtEstadoActual.Name = "txtEstadoActual";
            this.txtEstadoActual.Size = new System.Drawing.Size(181, 38);
            this.txtEstadoActual.TabIndex = 146;
            // 
            // FormModificarHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(871, 704);
            this.Controls.Add(this.lblEstadoActual);
            this.Controls.Add(this.txtEstadoActual);
            this.Controls.Add(this.cboActualizarEstado);
            this.Controls.Add(this.lblActualizarEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumeroPersonas);
            this.Controls.Add(this.txtNumeroPersonas);
            this.Controls.Add(this.lblNumeroHabitacion);
            this.Controls.Add(this.txtNumeroHabitacion);
            this.Controls.Add(this.lblIdHabitacion);
            this.Controls.Add(this.txtIdHabitacion);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModificarHabitaciones";
            this.Text = "FormModificarHabitaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNumeroPersonas;
        private System.Windows.Forms.TextBox txtNumeroPersonas;
        private System.Windows.Forms.Label lblNumeroHabitacion;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.Label lblIdHabitacion;
        private System.Windows.Forms.TextBox txtIdHabitacion;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblActualizarEstado;
        private System.Windows.Forms.ComboBox cboActualizarEstado;
        private System.Windows.Forms.Label lblEstadoActual;
        private System.Windows.Forms.TextBox txtEstadoActual;
    }
}