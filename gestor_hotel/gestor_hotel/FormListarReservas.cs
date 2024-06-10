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
    public partial class FormListarReservas : Form
    {
        private DaoReservas daoReservas = new DaoReservas();
        private Reserva reservaSeleccionada;    // Variable privada
        int idReservaDGV;
        public FormListarReservas()
        {
            InitializeComponent();
            SetPlaceholder();
            daoReservas.ListarDatos(dgvReservas);
        }

        #region PlaceHolder
        // Método para configurar el placeholder del TextBox
        private void SetPlaceholder()
        {
            // Establecemos el texto inicial del TextBox y lo ponemos de color gris
            txtBuscarReservas.Text = "Buscar";
            txtBuscarReservas.ForeColor = Color.Gray;

            txtBuscarReservas.Enter += RemovePlaceholder;    // Actua cuando txtBuscarReservas recibe el foco
            txtBuscarReservas.Leave += SetPlaceholder;   // Actua cuando txtBuscarReservas pierde el foco
        }

        // Evento Enter
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            // Si el texto es "Buscar", borra el texto y lo pone en negro
            if (txtBuscarReservas.Text == "Buscar")
            {
                txtBuscarReservas.Text = "";
                txtBuscarReservas.ForeColor = Color.Black;
            }
        }

        // Evento Leave
        private void SetPlaceholder(object sender, EventArgs e)
        {
            // Si el texto está vacío o solo contiene espacios en blanco, restaura el texto "Buscar" y pone el texto en gris
            if (string.IsNullOrWhiteSpace(txtBuscarReservas.Text))
            {
                txtBuscarReservas.Text = "Buscar";
                txtBuscarReservas.ForeColor = Color.Gray;
            }
        }
        #endregion

        private FormEliminarReservas formEliminar;  // Declarar el formulario como variable de clase
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (reservaSeleccionada != null)
            {
                    if (daoReservas.EsReservaCancelada(reservaSeleccionada.idReserva) == false)
                    {
                        // Pasar el objeto reserva al nuevo formulario
                        formEliminar = new FormEliminarReservas(reservaSeleccionada);    // Crear una nueva instancia
                        //this.Hide();  // Útil
                        formEliminar.Show();
                        //formEliminar.FormClosed += (s, args) => this.Show(); // Útil
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar una reserva cancelada.", "Reserva cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            } else
            {
                // Mostramos un mensaje si no se ha seleccionado ninguna reserva
                MessageBox.Show("Por favor, seleccione una reserva para eliminar.", "Reserva no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private FormModificarReservas formModificar;    // Declarar el formulario como variable de clase
        private void btnModificar_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (reservaSeleccionada != null)
            {
                if (daoReservas.EsReservaCancelada(reservaSeleccionada.idReserva) == false)
                {
                    // Pasar el objeto reserva al nuevo formulario
                    formModificar = new FormModificarReservas(reservaSeleccionada);    // Crear una nueva instancia
                                                                                       //this.Hide();  // Útil
                    formModificar.Show();
                    //formModificar.FormClosed += (s, args) => this.Show(); // Útil
                }
                else
                {
                    MessageBox.Show("No se puede modificar una reserva cancelada.", "Reserva cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mostramos un mensaje si no se ha seleccionado ninguna reserva
                MessageBox.Show("Por favor, seleccione una reserva para eliminar.", "Reserva no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            daoReservas.ListarDatos(dgvReservas);
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nos aseguramos de que no sea la columna de encabezado
            {
                DataGridViewRow row = dgvReservas.Rows[e.RowIndex];

                int idReserva = Convert.ToInt32(row.Cells["id_reserva"].Value);
                int idCliente = Convert.ToInt32(row.Cells["id_cliente"].Value);
                int idHabitacion = Convert.ToInt32(row.Cells["id_habitacion"].Value);
                DateTime fechaEntrada = Convert.ToDateTime(row.Cells["fecha_entrada"].Value);
                DateTime fechaSalida = Convert.ToDateTime(row.Cells["fecha_salida"].Value);
                decimal coste = Convert.ToDecimal(row.Cells["coste"].Value);
                int idEmpleado = Convert.ToInt32(row.Cells["id_empleado"].Value);
                DateTime fechaReserva = Convert.ToDateTime(row.Cells["fecha_reserva"].Value);
                DateTime? fechaCancelacionReserva = row.Cells["fecha_cancelacion_reserva"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["fecha_cancelacion_reserva"].Value) : (DateTime?)null;
                string observaciones = row.Cells["observaciones"].Value != null ? row.Cells["observaciones"].Value.ToString() : null;

                // Creamos el objeto Reserva y se lo pasamos a la variable reservaSeleccionada (nuevo formulario)
                reservaSeleccionada = new Reserva(idReserva, idCliente, idHabitacion, fechaEntrada, fechaSalida, coste, idEmpleado, fechaReserva, fechaCancelacionReserva, observaciones);
            }
        }

        private void dgvReservas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            // Obtenemos el indice de la columna del DataGridView
            if (this.dgvReservas.Columns[e.ColumnIndex].Name == "fecha_cancelacion_reserva")
            {
                // Distinto de null
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                        e.CellStyle.BackColor = Color.Red;
                }
                catch (NullReferenceException ex) { MessageBox.Show("" + ex); }
            }

            // Obtenemos el indice de la columna del DataGridView
            if (this.dgvReservas.Columns[e.ColumnIndex].Name == "id_reserva")
            {
                // Distinto de null
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                        idReservaDGV = Convert.ToInt32(e.Value);
                }
                catch (NullReferenceException ex) { MessageBox.Show("" + ex); }
            }

            // Obtenemos el indice de la columna del DataGridView
            if (this.dgvReservas.Columns[e.ColumnIndex].Name == "fecha_salida")
            {
                // Distinto de null
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        DateTime fechaSalida = Convert.ToDateTime(e.Value);

                        // Calculamos la diferencia en días entre la fecha de salida y hoy
                        TimeSpan diferencia = fechaSalida.Date - DateTime.Today;

                        // Verificamos si la reserva está cancelada
                        bool cancelada = daoReservas.EsReservaCancelada(idReservaDGV);

                        // Si queda 1 día o menos, cambiamos el fondo de la celda a naranja
                        if (diferencia.TotalDays <= 1)
                        {
                            e.CellStyle.BackColor = Color.Orange;
                        }
                        // Si la reserva ya ha terminado o la reserva ha sido cancelada, ponemos el fondo de la celda de color rojo
                        if (fechaSalida < DateTime.Today || cancelada == true)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                    }
                }
                catch (NullReferenceException ex) { MessageBox.Show("" + ex); }
            }
        }
    }
}
