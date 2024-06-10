namespace gestor_hotel
{
    partial class FormInicioSesion
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
            this.panBarraTitulo = new System.Windows.Forms.Panel();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            this.panContenedor = new System.Windows.Forms.Panel();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnInicioSesion = new System.Windows.Forms.Button();
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
            this.panBarraTitulo.TabIndex = 2;
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
            this.panContenedor.Controls.Add(this.lblContrasena);
            this.panContenedor.Controls.Add(this.lblNombreUsuario);
            this.panContenedor.Controls.Add(this.lblTitulo);
            this.panContenedor.Controls.Add(this.txtContrasena);
            this.panContenedor.Controls.Add(this.txtUsuario);
            this.panContenedor.Controls.Add(this.btnInicioSesion);
            this.panContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContenedor.Location = new System.Drawing.Point(0, 40);
            this.panContenedor.Name = "panContenedor";
            this.panContenedor.Size = new System.Drawing.Size(480, 660);
            this.panContenedor.TabIndex = 4;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(151, 318);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(161, 32);
            this.lblContrasena.TabIndex = 5;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(101, 169);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(258, 32);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(56, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(367, 54);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Inicio de Sesión";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(95, 363);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '·';
            this.txtContrasena.Size = new System.Drawing.Size(281, 38);
            this.txtContrasena.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(95, 222);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(281, 38);
            this.txtUsuario.TabIndex = 1;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.Location = new System.Drawing.Point(118, 480);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(228, 47);
            this.btnInicioSesion.TabIndex = 0;
            this.btnInicioSesion.Text = "Entrar";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 700);
            this.Controls.Add(this.panContenedor);
            this.Controls.Add(this.panBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicioSesion";
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
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.TextBox txtContrasena;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnInicioSesion;
    }
}