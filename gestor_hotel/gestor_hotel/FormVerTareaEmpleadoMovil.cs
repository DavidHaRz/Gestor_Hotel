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
    public partial class FormVerTareaEmpleadoMovil : Form
    {
        DaoRegistroEmpleados daoRegistroEmpleados = new DaoRegistroEmpleados();
        private ServicioRealizado servicioRealizadoSeleccionado;
        int id_empleado;
        string numeroHabitacion;
        public FormVerTareaEmpleadoMovil(ServicioRealizado servicioRealizadoSeleccionado, int id_empleado, string numeroHabitacion)
        {
            InitializeComponent();
            this.servicioRealizadoSeleccionado = servicioRealizadoSeleccionado;
            this.id_empleado = id_empleado;
            this.numeroHabitacion = numeroHabitacion;
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Mostramos los datos del servicio realizado
            txtIdServicioRealizado.Text = servicioRealizadoSeleccionado.idServicioRealizado.ToString();
            txtIdServicioDisponible.Text = servicioRealizadoSeleccionado.idServicioDisponible.ToString();
            txtIdHabitacion.Text = servicioRealizadoSeleccionado.idHabitacion.ToString();
            txtNumeroHabitacion.Text = numeroHabitacion;
            txtPrecio.Text = servicioRealizadoSeleccionado.precioTotalServicios.ToString() + " €";

            if (servicioRealizadoSeleccionado.hecho.ToString() == "")
                txtHecho.Text = "No Realizada";
            else
                txtHecho.Text = servicioRealizadoSeleccionado.hecho.ToString();

            if (servicioRealizadoSeleccionado.fechaCancelacion.ToString() == "")
                txtFechaCancelacion.Text = "No Cancelada";
            else
                txtFechaCancelacion.Text = servicioRealizadoSeleccionado.fechaCancelacion.ToString();


            //dtpFechaEntrada.Value = servicioRealizadoSeleccionado.fechaEntrada;
            //dtpFechaSalida.Value = servicioRealizadoSeleccionado.fechaSalida;
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

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            daoRegistroEmpleados.CerrarSesionEmpleado(id_empleado);
            Application.Exit();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
