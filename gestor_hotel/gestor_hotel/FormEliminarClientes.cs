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
    public partial class FormEliminarClientes : Form
    {
        private DaoClientes daoClientes = new DaoClientes();
        private Cliente _cliente;   // Variable privada

        // Constructor que recibe un objeto Cliente
        public FormEliminarClientes(Cliente cliente)
        {
            InitializeComponent();
            _cliente = cliente;
            CargarDatosCliente();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar el cliente con DNI " + txtDNI.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si confirmamos el cliente será eliminado
            if (resultado == DialogResult.Yes)
            {
                daoClientes.EliminarCliente(txtDNI.Text);
                this.Close();
            }
        }
    }
}
