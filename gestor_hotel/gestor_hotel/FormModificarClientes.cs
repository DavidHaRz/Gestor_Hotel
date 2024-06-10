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
    public partial class FormModificarClientes : Form
    {
        private DaoClientes daoClientes = new DaoClientes();
        private Cliente _cliente;   // Variable privada
        
        // Constructor que recibe un objeto Cliente
        public FormModificarClientes(Cliente cliente)
        {
            InitializeComponent();
            _cliente = cliente;
            CargarDatosCliente();
            // Agregando controladores de evento
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Leave += txtEmail_Leave;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosCliente()
        {
            // Mostramos los datos del cliente
            txtNombre.Text = _cliente.nombre;
            txtApellidos.Text = _cliente.apellidos;
            txtDNI.Text = _cliente.dni;
            txtTelefono.Text = _cliente.telefono;
            txtEmail.Text = _cliente.email;
            txtDireccionFacturacion.Text = _cliente.direccionFacturacion;
            txtObservaciones.Text = _cliente.observaciones;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
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
                }
                else { txtApellidos.BackColor = Color.White; }

                // Verificar si el campo txtNombre está vacío
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    // Establecer el fondo en color LightCoral
                    txtNombre.BackColor = Color.LightCoral;
                    // Enfocar el campo txtNombre
                    txtNombre.Focus();
                }
                else { txtNombre.BackColor = Color.White; }

                // Verificar si el campo txtEmail está vacío
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    // Establecer el fondo en color LightCoral
                    txtEmail.BackColor = Color.LightCoral;
                    // Enfocar el campo txtEmail
                    txtEmail.Focus();
                }
                else { txtEmail.BackColor = Color.White; }
                #endregion

                // Si todos los campos son correctos muestra el mensaje
                if (!string.IsNullOrWhiteSpace(txtDNI.Text) && !string.IsNullOrWhiteSpace(txtApellidos.Text) && !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    // Mostrar un mensaje de confirmación
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea modificar el cliente?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si confirmamos el cliente será modificar
                    if (resultado == DialogResult.Yes)
                    {
                        daoClientes.ModificarCliente(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtTelefono.Text, txtEmail.Text, txtDireccionFacturacion.Text, txtObservaciones.Text);
                        this.Close();
                    }
                }
            }

        }
    }
}
