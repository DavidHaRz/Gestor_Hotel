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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestor_hotel
{
    public partial class FormListarClientes : Form
    {
        private DaoClientes daoClientes = new DaoClientes();
        private Cliente clienteSeleccionado;    // Variable privada
        public FormListarClientes()
        {
            InitializeComponent();
            SetPlaceholder();
            daoClientes.ListarDatos(dgvClientes);
        }

        #region PlaceHolder
        // Método para configurar el placeholder del TextBox
        private void SetPlaceholder()
        {
            // Establecemos el texto inicial del TextBox y lo ponemos de color gris
            txtBuscarCliente.Text = "Buscar";
            txtBuscarCliente.ForeColor = Color.Gray;

            txtBuscarCliente.Enter += RemovePlaceholder;    // Actua cuando txtBuscarCliente recibe el foco
            txtBuscarCliente.Leave += SetPlaceholder;   // Actua cuando txtBuscarCliente pierde el foco
        }

        // Evento Enter
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            // Si el texto es "Buscar", borra el texto y lo pone en negro
            if (txtBuscarCliente.Text == "Buscar")
            {
                txtBuscarCliente.Text = "";
                txtBuscarCliente.ForeColor = Color.Black;
            }
        }

        // Evento Leave
        private void SetPlaceholder(object sender, EventArgs e)
        {
            // Si el texto está vacío o solo contiene espacios en blanco, restaura el texto "Buscar" y pone el texto en gris
            if (string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
            {
                txtBuscarCliente.Text = "Buscar";
                txtBuscarCliente.ForeColor = Color.Gray;
            }
        }
        #endregion


        private FormEliminarClientes formEliminar;  // Declarar el formulario como variable de clase
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (clienteSeleccionado != null)
            {
                // Pasar el objeto cliente al nuevo formulario
                formEliminar = new FormEliminarClientes(clienteSeleccionado);    // Crear una nueva instancia
                //this.Hide();  // Útil
                formEliminar.Show();
                //formEliminar.FormClosed += (s, args) => this.Show(); // Útil
            }
            else
            {
                // Mostramos un mensaje si no se ha seleccionado ningún cliente
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private FormModificarClientes formModificar;    // Declarar el formulario como variable de clase
        private void btnModificar_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (clienteSeleccionado != null)
            {
                // Pasar el objeto cliente al nuevo formulario
                formModificar = new FormModificarClientes(clienteSeleccionado);    // Crear una nueva instancia
                //this.Hide();  // Útil
                formModificar.Show();
                //formModificar.FormClosed += (s, args) => this.Show(); // Útil
            }
            else
            {
                // Mostramos un mensaje si no se ha seleccionado ningún cliente
                MessageBox.Show("Por favor, seleccione un cliente para modificar.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CerrarFormularios()
        {
            // Verificar si hay un formulario de modificación abierto y cerrarlo si es necesario
            if (formModificar != null && !formModificar.IsDisposed)
            {
                formModificar.Close();
                formModificar.Dispose();    // Liberar recursos asociados al formulario anterior
            }

            // Verificar si hay un formulario de eliminación abierto y cerrarlo si es necesario
            if (formEliminar != null && !formEliminar.IsDisposed)
            {
                formEliminar.Close();
                formEliminar.Dispose(); // Liberar recursos asociados al formulario anterior
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nos aseguramos de que no sea la columna de encabezado
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                string nombre = row.Cells["nombre"].Value.ToString();
                string apellidos = row.Cells["apellidos"].Value.ToString();
                string dni = row.Cells["dni"].Value.ToString();
                string telefono = row.Cells["telefono"].Value != null ? row.Cells["telefono"].Value.ToString() : null;
                string email = row.Cells["email"].Value.ToString();
                string direccionFacturacion = row.Cells["direccion_facturacion"].Value != null ? row.Cells["direccion_facturacion"].Value.ToString() : null;
                string observaciones = row.Cells["observaciones"].Value != null ? row.Cells["observaciones"].Value.ToString() : null;

                // Creamos el objeto Cliente y se lo pasamos a la variable clienteSeleccionado (nuevo formulario)
                clienteSeleccionado = new Cliente(nombre, apellidos, dni, telefono, email, direccionFacturacion, observaciones);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            daoClientes.ListarDatos(dgvClientes);
        }
    }
}
