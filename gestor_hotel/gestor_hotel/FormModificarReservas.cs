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
    public partial class FormModificarReservas : Form
    {
        DaoClientes daoClientes = new DaoClientes();
        DaoHabitaciones daoHabitaciones = new DaoHabitaciones();
        DaoReservas daoReservas = new DaoReservas();
        int nochesTotales, idReserva;
        private Reserva _reserva;
        private DateTime fechaEntradaOriginal;
        public FormModificarReservas(Reserva reserva)
        {
            InitializeComponent();
            _reserva = reserva;
            //dtpFechaEntrada.Value = DateTime.Now.Date;
            //dtpFechaSalida.Value = DateTime.Now.Date.AddDays(1);
            CargarDatosReserva();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosReserva()
        {
            // Mostramos los datos de la reserva
            idReserva = _reserva.idReserva;
            txtIdEmpleado.Text = _reserva.idEmpleado.ToString();
            txtIdCliente.Text = _reserva.idCliente.ToString();
            txtIdHabitacion.Text = _reserva.idHabitacion.ToString();
            dtpFechaEntrada.Value= _reserva.fechaEntrada;
            dtpFechaSalida.Value = _reserva.fechaSalida;
            txtCoste.Text = _reserva.coste.ToString();
            txtObservaciones.Text = _reserva.observaciones;

            // Guaramos el valor de fecha de entrada en una variable para luego compararla a la hora de modificar
            fechaEntradaOriginal = _reserva.fechaEntrada;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (controlIdCliente() && controlIdHabitacion())
            {
                int idHabitacion = int.Parse(txtIdHabitacion.Text);
                DateTime fechaEntrada = dtpFechaEntrada.Value;
                DateTime fechaSalida = dtpFechaSalida.Value;
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
                        if (observaciones == null)
                            observaciones = "";

                        if (coste == 0)
                            MessageBox.Show("No puede haber 0 noches.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        bool funciona = daoReservas.ModificarReserva(idReserva, idCliente, idHabitacion, fechaEntrada, fechaSalida, coste, fechaReserva, observaciones);
                        if (funciona)
                            limpiarDatos();
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Recuerda calcular antes de modificar. Error en el formato de los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La habitación no está disponible en las fechas seleccionadas.", "Reserva no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DateTime nuevaFechaEntrada = dtpFechaEntrada.Value.Date;

            // Comprobar si la nueva fecha de entrada es anterior a la fecha original
            if (nuevaFechaEntrada < fechaEntradaOriginal && fechaEntradaOriginal <= fechaHoy)
            {
                MessageBox.Show("La fecha de entrada no puede ser anterior a la fecha que ya había.", "Fecha de entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaEntrada.Value = fechaEntradaOriginal; // Resetear la fecha de entrada a la fecha original
            }
            else
            { 
                // Asegurar que la fecha de salida es al menos un día después de la nueva fecha de entrada
                if (dtpFechaSalida.Value.Date <= nuevaFechaEntrada)
                {
                    dtpFechaSalida.Value = nuevaFechaEntrada.AddDays(1); // Resetear la fecha de salida a un día después de la fecha de entrada
                }

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

        #region ControlCoste
        private void txtCoste_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Permitir números, coma y teclas de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Solo permitir una coma
            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true;
                return;
            }

            // Asegurarse de que hay dos dígitos después de la coma
            if (textBox.Text.Contains(","))
            {
                string[] parts = textBox.Text.Split(',');

                if (parts.Length > 1 && parts[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCoste_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!textBox.Text.Contains(","))
                {
                    // Si no hay coma, agregar ",00"
                    textBox.Text += ",00";
                }
                else
                {
                    string[] parts = textBox.Text.Split(',');

                    if (parts.Length == 1 || string.IsNullOrEmpty(parts[1]))
                    {
                        // Si no hay nada después de la coma, agregar "00"
                        textBox.Text += "00";
                    }
                    else if (parts[1].Length == 1)
                    {
                        // Si hay un solo dígito después de la coma, agregar un "0"
                        textBox.Text += "0";
                    }
                }
            }
            else
            {
                // Si el texto está vacío, poner "0,00"
                textBox.Text = "0,00";
            }
        }
        #endregion

        private void limpiarDatos()
        {
            txtIdCliente.Text = null;
            txtIdHabitacion.Text = null;
            dtpFechaEntrada.Value = DateTime.Now.Date;
            dtpFechaSalida.Value = DateTime.Now.Date.AddDays(1);
            lblNochesTotales.Text = "0 Noches.";
            txtObservaciones.Text = null;
            this.Close();
        }

        
    }
}