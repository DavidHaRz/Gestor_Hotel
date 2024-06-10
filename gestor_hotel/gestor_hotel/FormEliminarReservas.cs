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
using gestor_hotel.dto;
using MySqlX.XDevAPI;

namespace gestor_hotel
{
    public partial class FormEliminarReservas : Form
    {
        private DaoReservas daoReservas = new DaoReservas();
        private Reserva _reserva;   // Variable privada
        DaoHabitaciones daoHabitaciones = new DaoHabitaciones();
        int idHabitacion;
        public FormEliminarReservas(Reserva reserva)
        {
            InitializeComponent();
            _reserva = reserva;
            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            // Comprobamos que el objeto reserva no esté vacío
            if (_reserva != null)
            {
                // Mostramos los datos del cliente en los controles del formulario
                txtIdCliente.Text = _reserva.idCliente.ToString();
                txtIdHabitacion.Text = _reserva.idHabitacion.ToString();
                txtIdEmpleado.Text = _reserva.idEmpleado.ToString();
                dtpFechaEntrada.Value = _reserva.fechaEntrada;
                dtpFechaSalida.Value = _reserva.fechaSalida;
                txtCoste.Text = _reserva.coste.ToString("F2") + " €"; // Formato de dos decimales
                txtObservaciones.Text = _reserva.observaciones;

                // Coger id de la habitación
                idHabitacion = int.Parse(txtIdHabitacion.Text);

                // Calcular el número total de noches
                int nochesTotales = (_reserva.fechaSalida - _reserva.fechaEntrada).Days;
                if (nochesTotales == 1) { lblNochesTotales.Text = nochesTotales.ToString() + " Noche."; }
                else { lblNochesTotales.Text = nochesTotales.ToString() + " Noches."; }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar esta reserva?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si confirmamos la reserva será cancelada
            if (resultado == DialogResult.Yes)
            {
                daoReservas.CancelarReserva(_reserva);
                // Cambiamos el estado de la habitación
                daoHabitaciones.ModificarEstadoHabitacion(idHabitacion, "libre");
                this.Close();
            }
        }
    }
}
