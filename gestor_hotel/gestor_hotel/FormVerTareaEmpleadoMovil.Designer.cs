namespace gestor_hotel
{
    partial class FormVerTareaEmpleadoMovil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerTareaEmpleadoMovil));
            this.panBarraTitulo = new System.Windows.Forms.Panel();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            this.panContenedor = new System.Windows.Forms.Panel();
            this.txtFechaCancelacion = new System.Windows.Forms.TextBox();
            this.txtHecho = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.txtIdHabitacion = new System.Windows.Forms.TextBox();
            this.txtIdServicioDisponible = new System.Windows.Forms.TextBox();
            this.txtIdServicioRealizado = new System.Windows.Forms.TextBox();
            this.lblIdHabitacion = new System.Windows.Forms.Label();
            this.lblFechaCancelación = new System.Windows.Forms.Label();
            this.lblHecho = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNumeroHabitacion = new System.Windows.Forms.Label();
            this.lblIdServicioDisponible = new System.Windows.Forms.Label();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.lblIdServicioRealizado = new System.Windows.Forms.Label();
            this.panBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            this.panContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBarraTitulo
            // 
            this.panBarraTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panBarraTitulo.Controls.Add(this.imgMinimizar);
            this.panBarraTitulo.Controls.Add(this.imgCerrar);
            this.panBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panBarraTitulo.Name = "panBarraTitulo";
            this.panBarraTitulo.Size = new System.Drawing.Size(480, 40);
            this.panBarraTitulo.TabIndex = 13;
            this.panBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panBarraTitulo_MouseDown);
            // 
            // imgMinimizar
            // 
            this.imgMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimizar.Image = global::gestor_hotel.Properties.Resources.minimazar;
            this.imgMinimizar.Location = new System.Drawing.Point(400, 0);
            this.imgMinimizar.Name = "imgMinimizar";
            this.imgMinimizar.Size = new System.Drawing.Size(27, 38);
            this.imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMinimizar.TabIndex = 3;
            this.imgMinimizar.TabStop = false;
            this.imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click);
            // 
            // imgCerrar
            // 
            this.imgCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCerrar.Image = global::gestor_hotel.Properties.Resources.cerrar;
            this.imgCerrar.Location = new System.Drawing.Point(441, 0);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(27, 38);
            this.imgCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCerrar.TabIndex = 0;
            this.imgCerrar.TabStop = false;
            this.imgCerrar.Click += new System.EventHandler(this.imgCerrar_Click);
            // 
            // panContenedor
            // 
            this.panContenedor.BackColor = System.Drawing.Color.AliceBlue;
            this.panContenedor.Controls.Add(this.txtFechaCancelacion);
            this.panContenedor.Controls.Add(this.txtHecho);
            this.panContenedor.Controls.Add(this.txtPrecio);
            this.panContenedor.Controls.Add(this.txtNumeroHabitacion);
            this.panContenedor.Controls.Add(this.txtIdHabitacion);
            this.panContenedor.Controls.Add(this.txtIdServicioDisponible);
            this.panContenedor.Controls.Add(this.txtIdServicioRealizado);
            this.panContenedor.Controls.Add(this.lblIdHabitacion);
            this.panContenedor.Controls.Add(this.lblFechaCancelación);
            this.panContenedor.Controls.Add(this.lblHecho);
            this.panContenedor.Controls.Add(this.lblPrecio);
            this.panContenedor.Controls.Add(this.lblNumeroHabitacion);
            this.panContenedor.Controls.Add(this.lblIdServicioDisponible);
            this.panContenedor.Controls.Add(this.btnRetroceder);
            this.panContenedor.Controls.Add(this.lblIdServicioRealizado);
            this.panContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContenedor.Location = new System.Drawing.Point(0, 0);
            this.panContenedor.Name = "panContenedor";
            this.panContenedor.Size = new System.Drawing.Size(480, 700);
            this.panContenedor.TabIndex = 14;
            // 
            // txtFechaCancelacion
            // 
            this.txtFechaCancelacion.Enabled = false;
            this.txtFechaCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCancelacion.Location = new System.Drawing.Point(85, 546);
            this.txtFechaCancelacion.Name = "txtFechaCancelacion";
            this.txtFechaCancelacion.Size = new System.Drawing.Size(330, 34);
            this.txtFechaCancelacion.TabIndex = 22;
            // 
            // txtHecho
            // 
            this.txtHecho.Enabled = false;
            this.txtHecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHecho.Location = new System.Drawing.Point(82, 449);
            this.txtHecho.Name = "txtHecho";
            this.txtHecho.Size = new System.Drawing.Size(333, 34);
            this.txtHecho.TabIndex = 21;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(283, 344);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 34);
            this.txtPrecio.TabIndex = 20;
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.Enabled = false;
            this.txtNumeroHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(295, 276);
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(132, 34);
            this.txtNumeroHabitacion.TabIndex = 19;
            // 
            // txtIdHabitacion
            // 
            this.txtIdHabitacion.Enabled = false;
            this.txtIdHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHabitacion.Location = new System.Drawing.Point(228, 215);
            this.txtIdHabitacion.Name = "txtIdHabitacion";
            this.txtIdHabitacion.Size = new System.Drawing.Size(132, 34);
            this.txtIdHabitacion.TabIndex = 18;
            // 
            // txtIdServicioDisponible
            // 
            this.txtIdServicioDisponible.Enabled = false;
            this.txtIdServicioDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdServicioDisponible.Location = new System.Drawing.Point(321, 147);
            this.txtIdServicioDisponible.Name = "txtIdServicioDisponible";
            this.txtIdServicioDisponible.Size = new System.Drawing.Size(132, 34);
            this.txtIdServicioDisponible.TabIndex = 17;
            // 
            // txtIdServicioRealizado
            // 
            this.txtIdServicioRealizado.Enabled = false;
            this.txtIdServicioRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdServicioRealizado.Location = new System.Drawing.Point(312, 78);
            this.txtIdServicioRealizado.Name = "txtIdServicioRealizado";
            this.txtIdServicioRealizado.Size = new System.Drawing.Size(132, 34);
            this.txtIdServicioRealizado.TabIndex = 16;
            // 
            // lblIdHabitacion
            // 
            this.lblIdHabitacion.AutoSize = true;
            this.lblIdHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdHabitacion.Location = new System.Drawing.Point(25, 215);
            this.lblIdHabitacion.Name = "lblIdHabitacion";
            this.lblIdHabitacion.Size = new System.Drawing.Size(173, 29);
            this.lblIdHabitacion.TabIndex = 15;
            this.lblIdHabitacion.Text = "Id Habitación:";
            // 
            // lblFechaCancelación
            // 
            this.lblFechaCancelación.AutoSize = true;
            this.lblFechaCancelación.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCancelación.Location = new System.Drawing.Point(121, 501);
            this.lblFechaCancelación.Name = "lblFechaCancelación";
            this.lblFechaCancelación.Size = new System.Drawing.Size(250, 29);
            this.lblFechaCancelación.TabIndex = 14;
            this.lblFechaCancelación.Text = "Fecha Cancelación: ";
            // 
            // lblHecho
            // 
            this.lblHecho.AutoSize = true;
            this.lblHecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHecho.Location = new System.Drawing.Point(198, 404);
            this.lblHecho.Name = "lblHecho";
            this.lblHecho.Size = new System.Drawing.Size(95, 29);
            this.lblHecho.TabIndex = 13;
            this.lblHecho.Text = "Hecho:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(25, 347);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(238, 29);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio del servicio:";
            // 
            // lblNumeroHabitacion
            // 
            this.lblNumeroHabitacion.AutoSize = true;
            this.lblNumeroHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroHabitacion.Location = new System.Drawing.Point(25, 281);
            this.lblNumeroHabitacion.Name = "lblNumeroHabitacion";
            this.lblNumeroHabitacion.Size = new System.Drawing.Size(244, 29);
            this.lblNumeroHabitacion.TabIndex = 11;
            this.lblNumeroHabitacion.Text = "Número Habitación:";
            // 
            // lblIdServicioDisponible
            // 
            this.lblIdServicioDisponible.AutoSize = true;
            this.lblIdServicioDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdServicioDisponible.Location = new System.Drawing.Point(25, 147);
            this.lblIdServicioDisponible.Name = "lblIdServicioDisponible";
            this.lblIdServicioDisponible.Size = new System.Drawing.Size(277, 29);
            this.lblIdServicioDisponible.TabIndex = 10;
            this.lblIdServicioDisponible.Text = "Id Servicio Disponible:";
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.Location = new System.Drawing.Point(170, 600);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(142, 62);
            this.btnRetroceder.TabIndex = 9;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // lblIdServicioRealizado
            // 
            this.lblIdServicioRealizado.AutoSize = true;
            this.lblIdServicioRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdServicioRealizado.Location = new System.Drawing.Point(25, 81);
            this.lblIdServicioRealizado.Name = "lblIdServicioRealizado";
            this.lblIdServicioRealizado.Size = new System.Drawing.Size(268, 29);
            this.lblIdServicioRealizado.TabIndex = 7;
            this.lblIdServicioRealizado.Text = "Id Servicio Realizado:";
            // 
            // FormVerTareaEmpleadoMovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(480, 700);
            this.Controls.Add(this.panBarraTitulo);
            this.Controls.Add(this.panContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVerTareaEmpleadoMovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVerTareaEmpleadoMovil";
            this.panBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            this.panContenedor.ResumeLayout(false);
            this.panContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBarraTitulo;
        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.PictureBox imgCerrar;
        private System.Windows.Forms.Panel panContenedor;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Label lblIdServicioRealizado;
        private System.Windows.Forms.Label lblIdServicioDisponible;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNumeroHabitacion;
        private System.Windows.Forms.Label lblFechaCancelación;
        private System.Windows.Forms.Label lblHecho;
        private System.Windows.Forms.Label lblIdHabitacion;
        private System.Windows.Forms.TextBox txtIdServicioRealizado;
        private System.Windows.Forms.TextBox txtIdServicioDisponible;
        private System.Windows.Forms.TextBox txtFechaCancelacion;
        private System.Windows.Forms.TextBox txtHecho;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.TextBox txtIdHabitacion;
    }
}