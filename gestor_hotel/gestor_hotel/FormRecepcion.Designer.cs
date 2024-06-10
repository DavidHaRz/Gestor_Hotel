namespace gestor_hotel
{
    partial class FormRecepcion
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
            this.imgRestaurar = new System.Windows.Forms.PictureBox();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.imgMaximizar = new System.Windows.Forms.PictureBox();
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            this.panMenuLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panSubmenuFacturas = new System.Windows.Forms.Panel();
            this.btnModificarFacturas = new System.Windows.Forms.Button();
            this.btnEliminarFacturas = new System.Windows.Forms.Button();
            this.btnListarFacturas = new System.Windows.Forms.Button();
            this.btnCrearFacturas = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnHabitaciones = new System.Windows.Forms.Button();
            this.panSubmenuReservas = new System.Windows.Forms.Panel();
            this.btnModificarReservas = new System.Windows.Forms.Button();
            this.btnEliminarReservas = new System.Windows.Forms.Button();
            this.btnListarReservas = new System.Windows.Forms.Button();
            this.btnCrearReservas = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.panSubmenuClientes = new System.Windows.Forms.Panel();
            this.btnModificarClientes = new System.Windows.Forms.Button();
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.btnCrearClientes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panLogo = new System.Windows.Forms.Panel();
            this.imgLogoSecundario = new System.Windows.Forms.PictureBox();
            this.panChildForm = new System.Windows.Forms.Panel();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.imgLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.panBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            this.panMenuLateral.SuspendLayout();
            this.panSubmenuFacturas.SuspendLayout();
            this.panSubmenuReservas.SuspendLayout();
            this.panSubmenuClientes.SuspendLayout();
            this.panLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoSecundario)).BeginInit();
            this.panChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panBarraTitulo
            // 
            this.panBarraTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panBarraTitulo.Controls.Add(this.imgRestaurar);
            this.panBarraTitulo.Controls.Add(this.imgMinimizar);
            this.panBarraTitulo.Controls.Add(this.imgMaximizar);
            this.panBarraTitulo.Controls.Add(this.imgCerrar);
            this.panBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panBarraTitulo.Name = "panBarraTitulo";
            this.panBarraTitulo.Size = new System.Drawing.Size(1183, 34);
            this.panBarraTitulo.TabIndex = 1;
            this.panBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panBarraTitulo_MouseDown);
            // 
            // imgRestaurar
            // 
            this.imgRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgRestaurar.Image = global::gestor_hotel.Properties.Resources.res;
            this.imgRestaurar.Location = new System.Drawing.Point(1119, 0);
            this.imgRestaurar.Name = "imgRestaurar";
            this.imgRestaurar.Size = new System.Drawing.Size(28, 38);
            this.imgRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRestaurar.TabIndex = 6;
            this.imgRestaurar.TabStop = false;
            this.imgRestaurar.Visible = false;
            this.imgRestaurar.Click += new System.EventHandler(this.imgRestaurar_Click);
            // 
            // imgMinimizar
            // 
            this.imgMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimizar.Image = global::gestor_hotel.Properties.Resources.minimazar;
            this.imgMinimizar.Location = new System.Drawing.Point(1086, 0);
            this.imgMinimizar.Name = "imgMinimizar";
            this.imgMinimizar.Size = new System.Drawing.Size(27, 38);
            this.imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMinimizar.TabIndex = 7;
            this.imgMinimizar.TabStop = false;
            this.imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click);
            // 
            // imgMaximizar
            // 
            this.imgMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMaximizar.Image = global::gestor_hotel.Properties.Resources.maxi;
            this.imgMaximizar.Location = new System.Drawing.Point(1119, 0);
            this.imgMaximizar.Name = "imgMaximizar";
            this.imgMaximizar.Size = new System.Drawing.Size(28, 38);
            this.imgMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMaximizar.TabIndex = 5;
            this.imgMaximizar.TabStop = false;
            this.imgMaximizar.Click += new System.EventHandler(this.imgMaximizar_Click);
            // 
            // imgCerrar
            // 
            this.imgCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCerrar.Image = global::gestor_hotel.Properties.Resources.cerrar;
            this.imgCerrar.Location = new System.Drawing.Point(1153, 0);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(27, 38);
            this.imgCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCerrar.TabIndex = 4;
            this.imgCerrar.TabStop = false;
            this.imgCerrar.Click += new System.EventHandler(this.imgCerrar_Click);
            // 
            // panMenuLateral
            // 
            this.panMenuLateral.AutoScroll = true;
            this.panMenuLateral.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.panMenuLateral.Controls.Add(this.panSubmenuFacturas);
            this.panMenuLateral.Controls.Add(this.btnFacturas);
            this.panMenuLateral.Controls.Add(this.btnServicios);
            this.panMenuLateral.Controls.Add(this.btnHabitaciones);
            this.panMenuLateral.Controls.Add(this.panSubmenuReservas);
            this.panMenuLateral.Controls.Add(this.btnReservas);
            this.panMenuLateral.Controls.Add(this.panSubmenuClientes);
            this.panMenuLateral.Controls.Add(this.btnClientes);
            this.panMenuLateral.Controls.Add(this.panLogo);
            this.panMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenuLateral.Location = new System.Drawing.Point(0, 34);
            this.panMenuLateral.Margin = new System.Windows.Forms.Padding(4);
            this.panMenuLateral.Name = "panMenuLateral";
            this.panMenuLateral.Size = new System.Drawing.Size(312, 704);
            this.panMenuLateral.TabIndex = 2;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.Image = global::gestor_hotel.Properties.Resources.SalirBueno;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 1050);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(291, 56);
            this.btnCerrarSesion.TabIndex = 14;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panSubmenuFacturas
            // 
            this.panSubmenuFacturas.BackColor = System.Drawing.Color.DodgerBlue;
            this.panSubmenuFacturas.Controls.Add(this.btnModificarFacturas);
            this.panSubmenuFacturas.Controls.Add(this.btnEliminarFacturas);
            this.panSubmenuFacturas.Controls.Add(this.btnListarFacturas);
            this.panSubmenuFacturas.Controls.Add(this.btnCrearFacturas);
            this.panSubmenuFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSubmenuFacturas.Location = new System.Drawing.Point(0, 835);
            this.panSubmenuFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.panSubmenuFacturas.Name = "panSubmenuFacturas";
            this.panSubmenuFacturas.Size = new System.Drawing.Size(291, 215);
            this.panSubmenuFacturas.TabIndex = 13;
            // 
            // btnModificarFacturas
            // 
            this.btnModificarFacturas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificarFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarFacturas.Enabled = false;
            this.btnModificarFacturas.FlatAppearance.BorderSize = 0;
            this.btnModificarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFacturas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarFacturas.Location = new System.Drawing.Point(0, 150);
            this.btnModificarFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarFacturas.Name = "btnModificarFacturas";
            this.btnModificarFacturas.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnModificarFacturas.Size = new System.Drawing.Size(291, 50);
            this.btnModificarFacturas.TabIndex = 3;
            this.btnModificarFacturas.Text = "Modificar";
            this.btnModificarFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarFacturas.UseVisualStyleBackColor = false;
            this.btnModificarFacturas.Click += new System.EventHandler(this.btnModificarFacturas_Click);
            // 
            // btnEliminarFacturas
            // 
            this.btnEliminarFacturas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarFacturas.Enabled = false;
            this.btnEliminarFacturas.FlatAppearance.BorderSize = 0;
            this.btnEliminarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFacturas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarFacturas.Location = new System.Drawing.Point(0, 100);
            this.btnEliminarFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarFacturas.Name = "btnEliminarFacturas";
            this.btnEliminarFacturas.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnEliminarFacturas.Size = new System.Drawing.Size(291, 50);
            this.btnEliminarFacturas.TabIndex = 2;
            this.btnEliminarFacturas.Text = "Eliminar";
            this.btnEliminarFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarFacturas.UseVisualStyleBackColor = false;
            this.btnEliminarFacturas.Click += new System.EventHandler(this.btnEliminarFacturas_Click);
            // 
            // btnListarFacturas
            // 
            this.btnListarFacturas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnListarFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarFacturas.FlatAppearance.BorderSize = 0;
            this.btnListarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarFacturas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnListarFacturas.Location = new System.Drawing.Point(0, 50);
            this.btnListarFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarFacturas.Name = "btnListarFacturas";
            this.btnListarFacturas.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnListarFacturas.Size = new System.Drawing.Size(291, 50);
            this.btnListarFacturas.TabIndex = 1;
            this.btnListarFacturas.Text = "Listar";
            this.btnListarFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarFacturas.UseVisualStyleBackColor = false;
            this.btnListarFacturas.Click += new System.EventHandler(this.btnListarFacturas_Click);
            // 
            // btnCrearFacturas
            // 
            this.btnCrearFacturas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCrearFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearFacturas.FlatAppearance.BorderSize = 0;
            this.btnCrearFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearFacturas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCrearFacturas.Location = new System.Drawing.Point(0, 0);
            this.btnCrearFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearFacturas.Name = "btnCrearFacturas";
            this.btnCrearFacturas.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnCrearFacturas.Size = new System.Drawing.Size(291, 50);
            this.btnCrearFacturas.TabIndex = 0;
            this.btnCrearFacturas.Text = "Crear";
            this.btnCrearFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearFacturas.UseVisualStyleBackColor = false;
            this.btnCrearFacturas.Click += new System.EventHandler(this.btnCrearFacturas_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFacturas.Location = new System.Drawing.Point(0, 779);
            this.btnFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFacturas.Size = new System.Drawing.Size(291, 56);
            this.btnFacturas.TabIndex = 12;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnServicios.Location = new System.Drawing.Point(0, 723);
            this.btnServicios.Margin = new System.Windows.Forms.Padding(4);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnServicios.Size = new System.Drawing.Size(291, 56);
            this.btnServicios.TabIndex = 11;
            this.btnServicios.Text = "Solicitar Personal de Ayuda / Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHabitaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitaciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHabitaciones.Location = new System.Drawing.Point(0, 667);
            this.btnHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHabitaciones.Size = new System.Drawing.Size(291, 56);
            this.btnHabitaciones.TabIndex = 8;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabitaciones.UseVisualStyleBackColor = false;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // panSubmenuReservas
            // 
            this.panSubmenuReservas.BackColor = System.Drawing.Color.DodgerBlue;
            this.panSubmenuReservas.Controls.Add(this.btnModificarReservas);
            this.panSubmenuReservas.Controls.Add(this.btnEliminarReservas);
            this.panSubmenuReservas.Controls.Add(this.btnListarReservas);
            this.panSubmenuReservas.Controls.Add(this.btnCrearReservas);
            this.panSubmenuReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSubmenuReservas.Location = new System.Drawing.Point(0, 452);
            this.panSubmenuReservas.Margin = new System.Windows.Forms.Padding(4);
            this.panSubmenuReservas.Name = "panSubmenuReservas";
            this.panSubmenuReservas.Size = new System.Drawing.Size(291, 215);
            this.panSubmenuReservas.TabIndex = 4;
            // 
            // btnModificarReservas
            // 
            this.btnModificarReservas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificarReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarReservas.Enabled = false;
            this.btnModificarReservas.FlatAppearance.BorderSize = 0;
            this.btnModificarReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarReservas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarReservas.Location = new System.Drawing.Point(0, 150);
            this.btnModificarReservas.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarReservas.Name = "btnModificarReservas";
            this.btnModificarReservas.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnModificarReservas.Size = new System.Drawing.Size(291, 50);
            this.btnModificarReservas.TabIndex = 3;
            this.btnModificarReservas.Text = "Modificar";
            this.btnModificarReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarReservas.UseVisualStyleBackColor = false;
            this.btnModificarReservas.Click += new System.EventHandler(this.btnModificarReservas_Click);
            // 
            // btnEliminarReservas
            // 
            this.btnEliminarReservas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarReservas.Enabled = false;
            this.btnEliminarReservas.FlatAppearance.BorderSize = 0;
            this.btnEliminarReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarReservas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarReservas.Location = new System.Drawing.Point(0, 100);
            this.btnEliminarReservas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarReservas.Name = "btnEliminarReservas";
            this.btnEliminarReservas.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnEliminarReservas.Size = new System.Drawing.Size(291, 50);
            this.btnEliminarReservas.TabIndex = 2;
            this.btnEliminarReservas.Text = "Eliminar";
            this.btnEliminarReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarReservas.UseVisualStyleBackColor = false;
            this.btnEliminarReservas.Click += new System.EventHandler(this.btnEliminarReservas_Click);
            // 
            // btnListarReservas
            // 
            this.btnListarReservas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnListarReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarReservas.FlatAppearance.BorderSize = 0;
            this.btnListarReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarReservas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnListarReservas.Location = new System.Drawing.Point(0, 50);
            this.btnListarReservas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarReservas.Name = "btnListarReservas";
            this.btnListarReservas.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnListarReservas.Size = new System.Drawing.Size(291, 50);
            this.btnListarReservas.TabIndex = 1;
            this.btnListarReservas.Text = "Listar";
            this.btnListarReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarReservas.UseVisualStyleBackColor = false;
            this.btnListarReservas.Click += new System.EventHandler(this.btnListarReservas_Click);
            // 
            // btnCrearReservas
            // 
            this.btnCrearReservas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCrearReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearReservas.FlatAppearance.BorderSize = 0;
            this.btnCrearReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReservas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCrearReservas.Location = new System.Drawing.Point(0, 0);
            this.btnCrearReservas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearReservas.Name = "btnCrearReservas";
            this.btnCrearReservas.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnCrearReservas.Size = new System.Drawing.Size(291, 50);
            this.btnCrearReservas.TabIndex = 0;
            this.btnCrearReservas.Text = "Crear";
            this.btnCrearReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearReservas.UseVisualStyleBackColor = false;
            this.btnCrearReservas.Click += new System.EventHandler(this.btnCrearReservas_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReservas.Location = new System.Drawing.Point(0, 396);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReservas.Size = new System.Drawing.Size(291, 56);
            this.btnReservas.TabIndex = 3;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // panSubmenuClientes
            // 
            this.panSubmenuClientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.panSubmenuClientes.Controls.Add(this.btnModificarClientes);
            this.panSubmenuClientes.Controls.Add(this.btnEliminarClientes);
            this.panSubmenuClientes.Controls.Add(this.btnListarClientes);
            this.panSubmenuClientes.Controls.Add(this.btnCrearClientes);
            this.panSubmenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSubmenuClientes.Location = new System.Drawing.Point(0, 181);
            this.panSubmenuClientes.Margin = new System.Windows.Forms.Padding(4);
            this.panSubmenuClientes.Name = "panSubmenuClientes";
            this.panSubmenuClientes.Size = new System.Drawing.Size(291, 215);
            this.panSubmenuClientes.TabIndex = 2;
            // 
            // btnModificarClientes
            // 
            this.btnModificarClientes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarClientes.Enabled = false;
            this.btnModificarClientes.FlatAppearance.BorderSize = 0;
            this.btnModificarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarClientes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarClientes.Location = new System.Drawing.Point(0, 150);
            this.btnModificarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarClientes.Name = "btnModificarClientes";
            this.btnModificarClientes.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnModificarClientes.Size = new System.Drawing.Size(291, 50);
            this.btnModificarClientes.TabIndex = 3;
            this.btnModificarClientes.Text = "Modificar";
            this.btnModificarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarClientes.UseVisualStyleBackColor = false;
            this.btnModificarClientes.Click += new System.EventHandler(this.btnModificarClientes_Click);
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarClientes.Enabled = false;
            this.btnEliminarClientes.FlatAppearance.BorderSize = 0;
            this.btnEliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarClientes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarClientes.Location = new System.Drawing.Point(0, 100);
            this.btnEliminarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnEliminarClientes.Size = new System.Drawing.Size(291, 50);
            this.btnEliminarClientes.TabIndex = 2;
            this.btnEliminarClientes.Text = "Eliminar";
            this.btnEliminarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarClientes.UseVisualStyleBackColor = false;
            this.btnEliminarClientes.Click += new System.EventHandler(this.btnEliminarClientes_Click);
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnListarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarClientes.FlatAppearance.BorderSize = 0;
            this.btnListarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarClientes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnListarClientes.Location = new System.Drawing.Point(0, 50);
            this.btnListarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnListarClientes.Size = new System.Drawing.Size(291, 50);
            this.btnListarClientes.TabIndex = 1;
            this.btnListarClientes.Text = "Listar";
            this.btnListarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarClientes.UseVisualStyleBackColor = false;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // btnCrearClientes
            // 
            this.btnCrearClientes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCrearClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearClientes.FlatAppearance.BorderSize = 0;
            this.btnCrearClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearClientes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCrearClientes.Location = new System.Drawing.Point(0, 0);
            this.btnCrearClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearClientes.Name = "btnCrearClientes";
            this.btnCrearClientes.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnCrearClientes.Size = new System.Drawing.Size(291, 50);
            this.btnCrearClientes.TabIndex = 0;
            this.btnCrearClientes.Text = "Crear";
            this.btnCrearClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearClientes.UseVisualStyleBackColor = false;
            this.btnCrearClientes.Click += new System.EventHandler(this.btnCrearClientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Location = new System.Drawing.Point(0, 125);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(291, 56);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panLogo
            // 
            this.panLogo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panLogo.Controls.Add(this.imgLogoSecundario);
            this.panLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLogo.Location = new System.Drawing.Point(0, 0);
            this.panLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panLogo.Name = "panLogo";
            this.panLogo.Size = new System.Drawing.Size(291, 125);
            this.panLogo.TabIndex = 0;
            // 
            // imgLogoSecundario
            // 
            this.imgLogoSecundario.BackColor = System.Drawing.Color.DodgerBlue;
            this.imgLogoSecundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLogoSecundario.Image = global::gestor_hotel.Properties.Resources.icon1;
            this.imgLogoSecundario.Location = new System.Drawing.Point(0, 0);
            this.imgLogoSecundario.Name = "imgLogoSecundario";
            this.imgLogoSecundario.Size = new System.Drawing.Size(291, 125);
            this.imgLogoSecundario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoSecundario.TabIndex = 0;
            this.imgLogoSecundario.TabStop = false;
            // 
            // panChildForm
            // 
            this.panChildForm.BackColor = System.Drawing.Color.AliceBlue;
            this.panChildForm.Controls.Add(this.lblEmpleado);
            this.panChildForm.Controls.Add(this.imgLogoPrincipal);
            this.panChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChildForm.Location = new System.Drawing.Point(312, 34);
            this.panChildForm.Name = "panChildForm";
            this.panChildForm.Size = new System.Drawing.Size(871, 704);
            this.panChildForm.TabIndex = 3;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(49, 38);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(0, 42);
            this.lblEmpleado.TabIndex = 2;
            // 
            // imgLogoPrincipal
            // 
            this.imgLogoPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogoPrincipal.Image = global::gestor_hotel.Properties.Resources.recepcion2;
            this.imgLogoPrincipal.Location = new System.Drawing.Point(252, 216);
            this.imgLogoPrincipal.Name = "imgLogoPrincipal";
            this.imgLogoPrincipal.Size = new System.Drawing.Size(401, 371);
            this.imgLogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoPrincipal.TabIndex = 0;
            this.imgLogoPrincipal.TabStop = false;
            // 
            // FormRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 738);
            this.Controls.Add(this.panChildForm);
            this.Controls.Add(this.panMenuLateral);
            this.Controls.Add(this.panBarraTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1183, 738);
            this.Name = "FormRecepcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecepcion";
            this.panBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            this.panMenuLateral.ResumeLayout(false);
            this.panSubmenuFacturas.ResumeLayout(false);
            this.panSubmenuReservas.ResumeLayout(false);
            this.panSubmenuClientes.ResumeLayout(false);
            this.panLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoSecundario)).EndInit();
            this.panChildForm.ResumeLayout(false);
            this.panChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBarraTitulo;
        private System.Windows.Forms.Panel panMenuLateral;
        private System.Windows.Forms.Button btnHabitaciones;
        private System.Windows.Forms.Panel panSubmenuReservas;
        private System.Windows.Forms.Button btnModificarReservas;
        private System.Windows.Forms.Button btnEliminarReservas;
        private System.Windows.Forms.Button btnListarReservas;
        private System.Windows.Forms.Button btnCrearReservas;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Panel panSubmenuClientes;
        private System.Windows.Forms.Button btnModificarClientes;
        private System.Windows.Forms.Button btnEliminarClientes;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.Button btnCrearClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.Panel panChildForm;
        private System.Windows.Forms.PictureBox imgRestaurar;
        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.PictureBox imgMaximizar;
        private System.Windows.Forms.PictureBox imgCerrar;
        private System.Windows.Forms.PictureBox imgLogoPrincipal;
        private System.Windows.Forms.PictureBox imgLogoSecundario;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Panel panSubmenuFacturas;
        private System.Windows.Forms.Button btnModificarFacturas;
        private System.Windows.Forms.Button btnEliminarFacturas;
        private System.Windows.Forms.Button btnListarFacturas;
        private System.Windows.Forms.Button btnCrearFacturas;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}