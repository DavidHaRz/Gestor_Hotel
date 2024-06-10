using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestor_hotel.dao;
using gestor_hotel.dto;

namespace gestor_hotel
{
    public partial class FormCrearClientes : Form
    {
        private DaoClientes daoClientes = new DaoClientes();
        private Cliente _cliente;   // Variable privada

        public FormCrearClientes()
        {
            InitializeComponent();
            // Agregando controladores de evento
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Leave += txtEmail_Leave;
        }

        #region ControlTxtTelefono
        // Control del txtTelefono para que solo se puedan introducir números
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un dígito y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento KeyPress
            }
        }
        #endregion

        #region ControlTxtEmail
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text))
            {
                txtEmail.BackColor = Color.White; // Color de fondo blanco si es válido
            }
            else
            {
                txtEmail.BackColor = Color.LightCoral; // Color de fondo rojo claro si no es válido
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida.", "Correo Electrónico Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus(); // Vuelve a enfocar el TextBox si el correo no es válido
            }
        }

        private bool IsValidEmail(string email)
        {
            // Expresión regular para validar un correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        #endregion

        private void btnCrear_Click(object sender, EventArgs e)
        {
            #region CompruebaCamposObligatorios

            // Verificar si el campo txtDNI está vacío
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                // Establecer el fondo en color LightCoral
                txtDNI.BackColor = Color.LightCoral;
                // Enfocar el campo txtDNI
                txtDNI.Focus();
            }
            else { txtDNI.BackColor = Color.White; }

            // Verificar si el campo txtApellidos está vacío
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                // Establecer el fondo en color LightCoral
                txtApellidos.BackColor = Color.LightCoral;
                // Enfocar el campo txtApellidos
                txtApellidos.Focus();
            } else { txtApellidos.BackColor = Color.White;}

            // Verificar si el campo txtNombre está vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                // Establecer el fondo en color LightCoral
                txtNombre.BackColor = Color.LightCoral;
                // Enfocar el campo txtNombre
                txtNombre.Focus();
            } else { txtNombre.BackColor = Color.White; }

            // Verificar si el campo txtEmail está vacío
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                // Establecer el fondo en color LightCoral
                txtEmail.BackColor = Color.LightCoral;
                // Enfocar el campo txtEmail
                txtEmail.Focus();
            } else { txtEmail.BackColor = Color.White; }
            #endregion

            // Si todos los campos son correctos muestra el mensaje
            if (!string.IsNullOrWhiteSpace(txtDNI.Text) && !string.IsNullOrWhiteSpace(txtApellidos.Text) && !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                // Mostrar un mensaje de confirmación
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea crear el cliente " + txtNombre.Text + " " + txtApellidos.Text + "?", "Confirmar creación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si confirmamos el cliente será creado
                if (resultado == DialogResult.Yes)
                {
                    _cliente = new Cliente(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtTelefono.Text, txtEmail.Text, txtDireccionFacturacion.Text, txtObservaciones.Text);
                    daoClientes.CrearCliente(_cliente);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos del cliente o alguno es incorrecto.", "Verificar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
