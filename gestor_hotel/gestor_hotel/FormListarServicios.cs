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
    public partial class FormListarServicios : Form
    {
        private DaoServiciosDisponibles daoServiciosDisponibles = new DaoServiciosDisponibles();
        private ServicioDisponible servicioDisponibleSeleccionado;    // Variable privada
        public FormListarServicios()
        {
            InitializeComponent();
            daoServiciosDisponibles.ListarDatos(dgvServicios);
        }


        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nos aseguramos de que no sea la columna de encabezado
            {
                DataGridViewRow row = dgvServicios.Rows[e.RowIndex];

                int idServicioDisponible = Convert.ToInt32(row.Cells["id_servicio_disponible"].Value);
                string nombre = row.Cells["nombre"].Value.ToString();
                string descripcion = row.Cells["descripcion"].Value.ToString();
                decimal coste = Convert.ToDecimal(row.Cells["precio_servicio_disponible"].Value);

                // Creamos el objeto servicioDisponible y se lo pasamos a la variable servicioDisponibleSeleccionado (nuevo formulario)
                servicioDisponibleSeleccionado = new ServicioDisponible(idServicioDisponible, nombre, descripcion, coste);
            }
        }


        private FormContratarServicios formContratarServicios;    // Declarar el formulario como variable de clase
        private void btnContratarServicio_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (servicioDisponibleSeleccionado != null)
            {
                // Pasar el objeto servicio al nuevo formulario
                formContratarServicios = new FormContratarServicios(servicioDisponibleSeleccionado);    // Crear una nueva instancia
                formContratarServicios.Show();
            }
            else
            {
                // Mostramos un mensaje si no se ha seleccionado ningún servicio
                MessageBox.Show("Por favor, seleccione un servicio para modificar.", "Servicio no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CerrarFormularios()
        {
            // Verificar si hay un formulario abierto y cerrarlo si es necesario
            if (formContratarServicios != null && !formContratarServicios.IsDisposed)
            {
                formContratarServicios.Close();
                formContratarServicios.Dispose();    // Liberar recursos asociados al formulario anterior
            }
        }
    }
}
