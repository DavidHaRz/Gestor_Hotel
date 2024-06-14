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

namespace gestor_hotel
{
    public partial class FormCrearReservas : Form
    {
        int idEmpleado;
        DaoClientes daoClientes = new DaoClientes();
        DaoHabitaciones daoHabitaciones = new DaoHabitaciones();
        DaoReservas daoReservas = new DaoReservas();
        DaoFacturas daoFacturas = new DaoFacturas();
        int nochesTotales;
        public FormCrearReservas()
        {
            InitializeComponent();
            dtpFechaEntrada.Value = DateTime.Now.Date;
            dtpFechaSalida.Value = DateTime.Now.Date.AddDays(1);
        }

        public FormCrearReservas(int id_empleado)
        {
            InitializeComponent();
            this.idEmpleado = id_empleado;
            dtpFechaEntrada.Value = DateTime.Now.Date;
            dtpFechaSalida.Value = DateTime.Now.Date.AddDays(1);
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un dígito y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
        }

        private void txtIdHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un dígito y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (controlIdCliente() && controlIdHabitacion())
            {
                int idHabitacion = int.Parse(txtIdHabitacion.Text);
                DateTime fechaEntrada = dtpFechaEntrada.Value;
                DateTime fechaSalida = dtpFechaSalida.Value;

                if (daoHabitaciones.EsHabitacionBloqueada(idHabitacion))
                {
                    MessageBox.Show("No se puede crear la reserva porque la habitación está bloqueada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (daoHabitaciones.ComprobarDisponibilidadHabitacion(idHabitacion, fechaEntrada, fechaSalida))
                    {
                        try
                        {
                            int idCliente = int.Parse(txtIdCliente.Text);
                            //int idHabitacion = int.Parse(txtIdHabitacion.Text);
                            //DateTime fechaEntrada = dtpFechaEntrada.Value;
                            //DateTime fechaSalida = dtpFechaSalida.Value;
                            decimal coste = decimal.Parse(txtCoste.Text);
                            DateTime fechaReserva = DateTime.Now;
                            string observaciones = txtObservaciones.Text;
                            // Valor nullable para fecha_cancelacion_reserva
                            DateTime? fechaCancelacionReserva = null;
                            if (observaciones == null)
                                observaciones = "";

                            //if (coste == 0)
                            //    MessageBox.Show("No puede haber 0 noches.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            bool funciona = daoReservas.CrearReserva(idCliente, idHabitacion, fechaEntrada, fechaSalida, coste, idEmpleado, fechaReserva, fechaCancelacionReserva, observaciones);
                            // Cambiamos el estado de la habitación
                            //daoHabitaciones.ModificarEstadoHabitacion(idHabitacion, "ocupado");
                            daoFacturas.CrearFacturaInicial(idCliente, coste);
                            if (funciona)
                                limpiarDatos();
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Recuerda calcular antes de crear. Error en el formato de los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al crear la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La habitación no está disponible en las fechas seleccionadas.", "Reserva no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
        }

        private void calcular()
        {
            if (controlIdHabitacion())
            {
                int idHabitacion = Convert.ToInt32(txtIdHabitacion.Text);
                decimal precioHabitacion = daoHabitaciones.ObtenerPrecioHabitacion(idHabitacion);
                decimal precio = precioHabitacion * nochesTotales;
                txtCoste.Text = Convert.ToString(precio);
            }
        }

        private bool controlIdCliente()
        {
            bool clienteValido = false;
            if (!string.IsNullOrWhiteSpace(txtIdCliente.Text)) 
            {
                int idCliente = Convert.ToInt32(txtIdCliente.Text);
                bool clienteExiste = daoClientes.ClienteExiste(idCliente);

                if (!clienteExiste)
                {
                    MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdCliente.BackColor = Color.LightCoral;
                    txtIdCliente.Focus();
                }
                else
                {
                    txtIdCliente.BackColor = Color.White;
                    clienteValido = true;
                }
            } 
            else
            {
                MessageBox.Show("Debe rellenar el campo ID Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdCliente.BackColor = Color.LightCoral;
                txtIdCliente.Focus();
            }
            return clienteValido;
        }

        private bool controlIdHabitacion()
        {
            bool habitacionValida = false;
            if (!string.IsNullOrWhiteSpace(txtIdHabitacion.Text))
            {
                int idHabitacion = Convert.ToInt32(txtIdHabitacion.Text);
                bool habitacionExiste = daoHabitaciones.HabitacionExiste(idHabitacion);

                if (!habitacionExiste)
                {
                    MessageBox.Show("La habitación no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdHabitacion.BackColor = Color.LightCoral;
                    txtIdHabitacion.Focus();
                }
                else
                {
                    txtIdHabitacion.BackColor = Color.White;
                    habitacionValida = true;
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar el campo ID Habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdHabitacion.BackColor = Color.LightCoral;
                txtIdHabitacion.Focus();
            }
            return habitacionValida;
        }

        private void dtpFechaEntrada_ValueChanged(object sender, EventArgs e)
        {
            funcionalidadFechaEntrada();
        }

        private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {
            funcionalidadFechaSalida();
        }

        private void funcionalidadFechaEntrada()
        {
            DateTime fechaHoy = DateTime.Now.Date;
            DateTime fechaEntrada = dtpFechaEntrada.Value.Date;
            DateTime fechaSalida = dtpFechaSalida.Value.Date;

            // Comprobar si la fecha de entrada es anterior a hoy
            if (fechaEntrada < fechaHoy)
            {
                MessageBox.Show("La fecha de entrada no puede ser anterior a la fecha de hoy.", "Fecha de entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaEntrada.Value = fechaHoy; // Resetear la fecha de entrada a hoy
            }
            else
            {
                dtpFechaSalida.Value = fechaEntrada.AddDays(1); // Resetear la fecha de salida a un día después de la fecha de entrada

                funcionalidadFechaSalida();
            }
        }

        private void funcionalidadFechaSalida()
        {
            DateTime fechaEntrada = dtpFechaEntrada.Value.Date;
            DateTime fechaSalida = dtpFechaSalida.Value.Date;

            // Comprobar si la fecha de salida es posterior o igual a la fecha de entrada
            if (fechaSalida <= fechaEntrada)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la fecha de entrada.", "Fecha de salida no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaSalida.Value = fechaEntrada.AddDays(1); // Resetear la fecha de salida a un día después de la fecha de entrada
            }
            else
            {
                // Calcular el número total de noches
                nochesTotales = (fechaSalida - fechaEntrada).Days;
                if (nochesTotales == 1) { lblNochesTotales.Text = nochesTotales.ToString() + " Noche."; }
                else { lblNochesTotales.Text = nochesTotales.ToString() + " Noches."; }
                if (txtIdHabitacion.Text != "")   // Se hace para que no salte mensaje al entrar a la ventana "crear"
                    calcular();
            }
        }

        private void limpiarDatos()
        {
            txtIdCliente.Text = null;
            txtIdHabitacion.Text = null;
            dtpFechaEntrada.Value = DateTime.Now.Date;
            dtpFechaSalida.Value = DateTime.Now.Date.AddDays(1);
            lblNochesTotales.Text = "0 Noches.";
            txtObservaciones.Text = null;
        }
    }
}
