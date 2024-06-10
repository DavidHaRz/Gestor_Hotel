using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestor_hotel.dao;

namespace gestor_hotel
{
    public partial class FormCocina : Form
    {
        DaoRegistroEmpleados daoRegistroEmpleados = new DaoRegistroEmpleados();
        int id_empleado;
        string nombre_empleado;
        public FormCocina()
        {
            InitializeComponent();
        }
        public FormCocina(int id_empleado, string nombre_empleado)
        {
            InitializeComponent();
            this.id_empleado = id_empleado;
            this.nombre_empleado = nombre_empleado;
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            daoRegistroEmpleados.CerrarSesionEmpleado(id_empleado);
            Application.Exit();
        }

        private void imgRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            imgRestaurar.Visible = false;
            imgMaximizar.Visible = true;
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            imgMaximizar.Visible = false;
            imgRestaurar.Visible = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            daoRegistroEmpleados.CerrarSesionEmpleado(id_empleado);
            this.Close();
        }
    }
}
