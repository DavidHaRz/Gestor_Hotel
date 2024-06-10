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
    public partial class FormListarHabitaciones : Form
    {
        private DaoHabitaciones daoHabitaciones = new DaoHabitaciones();
        private Habitacion habitacionSeleccionada;    // Variable privada
        string estadoHabitacion;
        public FormListarHabitaciones()
        {
            InitializeComponent();
            SetPlaceholder();
            //daoHabitaciones.ListarDatos(dgvHabitaciones);
            daoHabitaciones.ActualizarEstadoHabitaciones(dgvHabitaciones);
        }

        #region PlaceHolder
        // Método para configurar el placeholder del TextBox
        private void SetPlaceholder()
        {
            // Establecemos el texto inicial del TextBox y lo ponemos de color gris
            txtBuscarHabitacion.Text = "Buscar";
            txtBuscarHabitacion.ForeColor = Color.Gray;

            txtBuscarHabitacion.Enter += RemovePlaceholder;    // Actua cuando txtBuscarHabitacion recibe el foco
            txtBuscarHabitacion.Leave += SetPlaceholder;   // Actua cuando txtBuscarHabitacion pierde el foco
        }

        // Evento Enter
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            // Si el texto es "Buscar", borra el texto y lo pone en negro
            if (txtBuscarHabitacion.Text == "Buscar")
            {
                txtBuscarHabitacion.Text = "";
                txtBuscarHabitacion.ForeColor = Color.Black;
            }
        }

        // Evento Leave
        private void SetPlaceholder(object sender, EventArgs e)
        {
            // Si el texto está vacío o solo contiene espacios en blanco, restaura el texto "Buscar" y pone el texto en gris
            if (string.IsNullOrWhiteSpace(txtBuscarHabitacion.Text))
            {
                txtBuscarHabitacion.Text = "Buscar";
                txtBuscarHabitacion.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void dgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nos aseguramos de que no sea la columna de encabezado
            {
                DataGridViewRow row = dgvHabitaciones.Rows[e.RowIndex];

                int idHabitacion = Convert.ToInt32(row.Cells["id_habitacion"].Value);
                string numeroHabitacion = row.Cells["numero_habitacion"].Value.ToString();
                int numeroPersonas = Convert.ToInt32(row.Cells["numero_personas"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                string estado = row.Cells["estado"].Value.ToString();

                // Creamos el objeto Habitacion y se lo pasamos a la variable habitacionSeleccionada (nuevo formulario)
                habitacionSeleccionada = new Habitacion(idHabitacion, numeroHabitacion, numeroPersonas, precio, estado);
            }
        }

        private FormModificarHabitaciones formModificar;    // Declarar el formulario como variable de clase
        private void CerrarFormularios()
        {
            // Verificar si hay un formulario de modificación abierto y cerrarlo si es necesario
            if (formModificar != null && !formModificar.IsDisposed)
            {
                formModificar.Close();
                formModificar.Dispose();    // Liberar recursos asociados al formulario anterior
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //daoHabitaciones.ListarDatos(dgvHabitaciones);
            daoHabitaciones.ActualizarEstadoHabitaciones(dgvHabitaciones);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (habitacionSeleccionada != null)
            {
                estadoHabitacion = daoHabitaciones.ObtenerEstadoHabitacion(habitacionSeleccionada.idHabitacion);

                if (estadoHabitacion == "libre" || estadoHabitacion == "bloqueada")
                {
                    // Pasar el objeto cliente al nuevo formulario
                    formModificar = new FormModificarHabitaciones(habitacionSeleccionada);    // Crear una nueva instancia
                                                                                              //this.Hide();  // Útil
                    formModificar.Show();
                    //formModificar.FormClosed += (s, args) => this.Show(); // Útil
                }
                else
                {
                    MessageBox.Show("No se puede modificar la habitación. Estado actual: " + estadoHabitacion, "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                // Mostramos un mensaje si no se ha seleccionado ningún cliente
                MessageBox.Show("Por favor, seleccione una habitación para modificar.", "Habitación no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvHabitaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Obtenemos el indice de la columna del DataGridView
            if (this.dgvHabitaciones.Columns[e.ColumnIndex].Name == "estado")
            {
                // Distinto de null
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        switch (Convert.ToString(e.Value))
                        {
                            case "libre":
                                //e.CellStyle.ForeColor = Color.Green;
                                dgvHabitaciones.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Lime;
                                break;
                            case "ocupado":
                                //e.CellStyle.ForeColor = Color.Red;
                                dgvHabitaciones.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            case "reservada":
                                //e.CellStyle.ForeColor = Color.Blue;
                                dgvHabitaciones.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                                break;
                            case "bloqueada":
                                dgvHabitaciones.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                                dgvHabitaciones.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Black;
                                break;
                            default:
                                break;
                        }

                    }
                } catch (NullReferenceException ex) { MessageBox.Show("" + ex); }
            }
        }
    }
}
