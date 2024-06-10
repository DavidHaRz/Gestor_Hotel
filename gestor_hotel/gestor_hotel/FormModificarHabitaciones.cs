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
    public partial class FormModificarHabitaciones : Form
    {
        DaoHabitaciones daoHabitaciones = new DaoHabitaciones();
        private Habitacion _habitacion;
        int idHabitacion;
        string estadoSeleccionado;
        public FormModificarHabitaciones(Habitacion habitacion)
        {
            InitializeComponent();
            _habitacion = habitacion;
            cargarDatosHabitacion();
        }

        private void cargarDatosHabitacion()
        {
            // Mostramos los datos de la habitacion
            idHabitacion = _habitacion.idHabitacion;
            txtIdHabitacion.Text = _habitacion.idHabitacion.ToString();
            txtNumeroHabitacion.Text = _habitacion.numeroHabitacion;
            txtNumeroPersonas.Text = _habitacion.numeroPersonas.ToString();
            txtPrecio.Text = _habitacion.precio.ToString();
            txtEstadoActual.Text = _habitacion.estado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal precio = decimal.Parse(txtPrecio.Text);
            int numeroPersonas = int.Parse(txtNumeroPersonas.Text);
            if (estadoSeleccionado == null)
                estadoSeleccionado = txtEstadoActual.Text;

            // Mostrar un mensaje de confirmación
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea modificar la habitación con id " + idHabitacion + " ?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si confirmamos la habitación será modificada
            if (resultado == DialogResult.Yes)
            {
                daoHabitaciones.ModificarHabitacion(idHabitacion, txtNumeroHabitacion.Text, numeroPersonas, precio, estadoSeleccionado);
                this.Close();
            }
        }


        #region ControlEstado
        private void cboActualizarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado
            estadoSeleccionado = cboActualizarEstado.SelectedItem.ToString();
        }
        #endregion

        #region ControlNumeroPersonas
        private void txtNumeroPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es una tecla de control (como backspace) y si el carácter ingresado no está entre '1' y '4'
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < '1' || e.KeyChar > '4'))
            {
                e.Handled = true;
            }

            // Verificar si el campo de texto ya tiene un carácter
            if (!char.IsControl(e.KeyChar) && txtNumeroPersonas.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region ControlPrecio
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecio_Leave(object sender, EventArgs e)
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
    }
}
