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
using gestor_hotel.dto;

namespace gestor_hotel
{
    public partial class FormInicioSesion : Form
    {
        private DaoRegistroEmpleados daoRegistroEmpleados = new DaoRegistroEmpleados();

        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            DaoEmpleados daoEmpleados = new DaoEmpleados();
            Empleado empleado = daoEmpleados.IniciarSesion(usuario, contrasena);

            if (empleado != null)
            {
                daoRegistroEmpleados.RegistrarEmpleado(empleado.id_empleado);
                // Abrir el formulario correspondiente en función del puesto
                Form formToOpen = null;
                switch (empleado.puesto)
                {
                    case "recepcionista":
                        formToOpen = new FormRecepcion(empleado.id_empleado, empleado.nombre);
                        break;
                    case "limpieza":
                        formToOpen = new FormEmpleadoMovil(empleado.id_empleado, empleado.nombre, empleado.puesto);
                        break;
                    case "personal_de_apoyo":
                        formToOpen = new FormEmpleadoMovil(empleado.id_empleado, empleado.nombre, empleado.puesto);
                        break;
                    case "masajista":
                        formToOpen = new FormEmpleadoMovil(empleado.id_empleado, empleado.nombre, empleado.puesto);
                        break;
                    case "cocina":
                        formToOpen = new FormCocina(empleado.id_empleado, empleado.nombre);
                        break;
                    default:
                        MessageBox.Show("Puesto desconocido: " + empleado.puesto);
                        return;
                }

                if (formToOpen != null)
                {
                    this.Hide(); // Oculta el FormInicioSesion
                    formToOpen.FormClosed += (s, args) =>
                    {
                        this.Show(); // Muestra el FormInicioSesion cuando el nuevo formulario se cierra
                        limpiaDatos(); // Limpia los datos al volver
                    };
                    formToOpen.ShowDialog(); // Muestra el formulario de destino de manera modal
                }
            }
            else
            {
                MessageBox.Show("Lo sentimos, el usuario o la contraseña que ingresaste no son correctos. Por favor, verifica tus datos e inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            limpiaDatos();
        }

        private void limpiaDatos()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        
    }
}
