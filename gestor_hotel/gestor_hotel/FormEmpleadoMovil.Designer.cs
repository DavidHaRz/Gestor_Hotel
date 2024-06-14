namespace gestor_hotel
{
    partial class FormEmpleadoMovil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleadoMovil));
            this.panBarraTitulo = new System.Windows.Forms.Panel();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.panContenedor = new System.Windows.Forms.Panel();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnVerTarea = new System.Windows.Forms.Button();
            this.lblListaTareas = new System.Windows.Forms.Label();
            this.imgCerrarSesion = new System.Windows.Forms.PictureBox();
            this.btnMarcarComoHecho = new System.Windows.Forms.Button();
            this.panBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            this.panContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrarSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // panBarraTitulo
            // 
            this.panBarraTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panBarraTitulo.Controls.Add(this.imgMinimizar);
            this.panBarraTitulo.Controls.Add(this.imgCerrar);
            this.panBarraTitulo.Controls.Add(this.lblPuesto);
            this.panBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panBarraTitulo.Name = "panBarraTitulo";
            this.panBarraTitulo.Size = new System.Drawing.Size(480, 40);
            this.panBarraTitulo.TabIndex = 11;
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
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(41, 6);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(0, 32);
            this.lblPuesto.TabIndex = 3;
            // 
            // panContenedor
            // 
            this.panContenedor.BackColor = System.Drawing.Color.AliceBlue;
            this.panContenedor.Controls.Add(this.dgvTareas);
            this.panContenedor.Controls.Add(this.lblEmpleado);
            this.panContenedor.Controls.Add(this.btnVerTarea);
            this.panContenedor.Controls.Add(this.lblListaTareas);
            this.panContenedor.Controls.Add(this.imgCerrarSesion);
            this.panContenedor.Controls.Add(this.btnMarcarComoHecho);
            this.panContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContenedor.Location = new System.Drawing.Point(0, 0);
            this.panContenedor.Name = "panContenedor";
            this.panContenedor.Size = new System.Drawing.Size(480, 700);
            this.panContenedor.TabIndex = 12;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToOrderColumns = true;
            this.dgvTareas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTareas.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTareas.ColumnHeadersHeight = 30;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTareas.EnableHeadersVisualStyles = false;
            this.dgvTareas.Location = new System.Drawing.Point(47, 140);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTareas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTareas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.Size = new System.Drawing.Size(380, 415);
            this.dgvTareas.TabIndex = 63;
            this.dgvTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellClick);
            this.dgvTareas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTareas_CellFormatting);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(73, 64);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(0, 32);
            this.lblEmpleado.TabIndex = 10;
            // 
            // btnVerTarea
            // 
            this.btnVerTarea.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTarea.Location = new System.Drawing.Point(273, 561);
            this.btnVerTarea.Name = "btnVerTarea";
            this.btnVerTarea.Size = new System.Drawing.Size(142, 62);
            this.btnVerTarea.TabIndex = 9;
            this.btnVerTarea.Text = "Ver Tarea";
            this.btnVerTarea.UseVisualStyleBackColor = false;
            this.btnVerTarea.Click += new System.EventHandler(this.btnVerTarea_Click);
            // 
            // lblListaTareas
            // 
            this.lblListaTareas.AutoSize = true;
            this.lblListaTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaTareas.Location = new System.Drawing.Point(120, 105);
            this.lblListaTareas.Name = "lblListaTareas";
            this.lblListaTareas.Size = new System.Drawing.Size(224, 32);
            this.lblListaTareas.TabIndex = 7;
            this.lblListaTareas.Text = "Lista de Tareas";
            // 
            // imgCerrarSesion
            // 
            this.imgCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCerrarSesion.Image = global::gestor_hotel.Properties.Resources.SalidaFormatoMovil;
            this.imgCerrarSesion.Location = new System.Drawing.Point(422, 634);
            this.imgCerrarSesion.Name = "imgCerrarSesion";
            this.imgCerrarSesion.Size = new System.Drawing.Size(55, 63);
            this.imgCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCerrarSesion.TabIndex = 6;
            this.imgCerrarSesion.TabStop = false;
            this.imgCerrarSesion.Click += new System.EventHandler(this.imgCerrarSesion_Click);
            // 
            // btnMarcarComoHecho
            // 
            this.btnMarcarComoHecho.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMarcarComoHecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarComoHecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarComoHecho.Location = new System.Drawing.Point(64, 561);
            this.btnMarcarComoHecho.Name = "btnMarcarComoHecho";
            this.btnMarcarComoHecho.Size = new System.Drawing.Size(142, 62);
            this.btnMarcarComoHecho.TabIndex = 0;
            this.btnMarcarComoHecho.Text = "Marcar como hecho";
            this.btnMarcarComoHecho.UseVisualStyleBackColor = false;
            this.btnMarcarComoHecho.Click += new System.EventHandler(this.btnMarcarComoHecho_Click);
            // 
            // FormEmpleadoMovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(480, 700);
            this.Controls.Add(this.panBarraTitulo);
            this.Controls.Add(this.panContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmpleadoMovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpleadoMovil";
            this.panBarraTitulo.ResumeLayout(false);
            this.panBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            this.panContenedor.ResumeLayout(false);
            this.panContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrarSesion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBarraTitulo;
        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.PictureBox imgCerrar;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Panel panContenedor;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Button btnVerTarea;
        private System.Windows.Forms.Label lblListaTareas;
        private System.Windows.Forms.PictureBox imgCerrarSesion;
        private System.Windows.Forms.Button btnMarcarComoHecho;
    }
}