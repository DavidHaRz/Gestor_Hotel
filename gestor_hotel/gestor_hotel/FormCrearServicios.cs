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
    public partial class FormCrearServicios : Form
    {
        DaoServiciosDisponibles daoServiciosDisponibles = new DaoServiciosDisponibles();
        public FormCrearServicios()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Verificar si el campo txtNombre está vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                // Establecer el fondo en color LightCoral
                txtNombre.BackColor = Color.LightCoral;
                // Enfocar el campo txtNombre
                txtNombre.Focus();
            }
            else { txtNombre.BackColor = Color.White; }

            if (string.IsNullOrWhiteSpace(txtCoste.Text))
            {
                txtCoste.BackColor = Color.LightCoral;
                txtCoste.Focus();
            }
            else { txtCoste.BackColor = Color.White; }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.BackColor = Color.LightCoral;
                txtDescripcion.Focus();
            }
            else { txtDescripcion.BackColor = Color.White; }

            // Si todos los campos son correctos muestra el mensaje
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtCoste.Text) && !string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                decimal coste = decimal.Parse(txtCoste.Text);
                // Mostrar un mensaje de confirmación
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea crear el servicio " + txtNombre.Text + "?", "Confirmar creación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si confirmamos el servicio será creado
                if (resultado == DialogResult.Yes)
                {
                    //daoServiciosDisponibles.CrearServicio(txtNombre.Text, txtDescripcion.Text, coste);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos del servicio o alguno es incorrecto.", "Verificar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
