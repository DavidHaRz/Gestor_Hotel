using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestor_hotel.dao;

namespace gestor_hotel
{
    public partial class FormRecepcion : Form
    {
        DaoRegistroEmpleados daoRegistroEmpleados = new DaoRegistroEmpleados();
        int id_empleado;
        public FormRecepcion()
        {
            InitializeComponent();
            customizeDesign();
        }
        public FormRecepcion(int id_empleado, string nombre_empleado)
        {
            InitializeComponent();
            customizeDesign();
            lblEmpleado.Text = nombre_empleado;
            this.id_empleado = id_empleado;
        }
        private void customizeDesign()
        {
            panSubmenuClientes.Visible = false;
            panSubmenuReservas.Visible = false;
            panSubmenuFacturas.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panSubmenuClientes.Visible)
                panSubmenuClientes.Visible = false;
            if (panSubmenuReservas.Visible)
                panSubmenuReservas.Visible = false;
            if (panSubmenuFacturas.Visible)
                panSubmenuFacturas.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            } else 
                submenu.Visible = false;
        }

        #region SubmenuClientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panSubmenuClientes);
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListarClientes());
            //Código
            hideSubMenu();
        }

        private void btnCrearClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCrearClientes());
            //Código
            hideSubMenu();
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormEliminarClientes());
            //Código
            hideSubMenu();
        }

        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormModificarClientes());
            //Código
            hideSubMenu();
        }

        #endregion

        private Form activeForm = null; // Almacenamos el formulario que se abre
        private void openChildForm(Form  childForm)    // Abrir un único formulario en el panel
        {
            // Si existe un formulario abierto, lo cerramos
            if (activeForm != null)
                activeForm.Close();

            // Guardamos el formulario que se abre en la variable activeForm
            activeForm = childForm;

            // El formulario hijo NO es de nivel superior
            childForm.TopLevel = false; // Se comportará igual que un control

            // Le quitamos el borde del formulario
            childForm.FormBorderStyle = FormBorderStyle.None;

            // Establecemos la propiedad Dock para llenar el panel contenedor
            childForm.Dock= DockStyle.Fill;

            // Agregamos el formulario a la lista de controles del panel contenedor
            panChildForm.Controls.Add(childForm);

            // Asociamos el formulario con el panel contenedor
            panChildForm.Tag = childForm;

            // Traemos el formulario hacia el frente
            childForm.BringToFront();   // Por si colocamos algún logo en el panel

            // Mostramos el formulario hijo
            childForm.Show();
        }



        #region panBarraTitulo
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

        //Para poder mover la ventana cuando se pincha en la barra de título.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        #region SubmenuReservas
        private void btnReservas_Click(object sender, EventArgs e)
        {
            showSubMenu(panSubmenuReservas);
        }

        private void btnListarReservas_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListarReservas());
            //Código
            hideSubMenu();
        }

        private void btnCrearReservas_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCrearReservas(id_empleado));
            //Código
            hideSubMenu();
        }

        private void btnEliminarReservas_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormEliminarReservas());
            //Código
            hideSubMenu();
        }

        private void btnModificarReservas_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormModificarReservas());
            //Código
            hideSubMenu();
        }
        #endregion

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListarHabitaciones());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListarServicios());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            daoRegistroEmpleados.CerrarSesionEmpleado(id_empleado);
            this.Close();
        }

        #region SubmenuFacturas
        private void btnFacturas_Click(object sender, EventArgs e)
        {
            showSubMenu(panSubmenuFacturas);
        }

        private void btnCrearFacturas_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCrearReservas(id_empleado));
            //Código
            hideSubMenu();
        }

        private void btnListarFacturas_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListarReservas());
            //Código
            hideSubMenu();
        }

        private void btnEliminarFacturas_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormEliminarReservas());
            //Código
            hideSubMenu();
        }

        private void btnModificarFacturas_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormModificarReservas());
            //Código
            hideSubMenu();
        }

        #endregion

    }
}
