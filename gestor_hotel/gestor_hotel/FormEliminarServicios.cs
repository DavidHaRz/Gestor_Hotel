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
    public partial class FormEliminarServicios : Form
    {
        private ServicioRealizado servicioRealizadoSeleccionado;    // Variable privada
        DaoServiciosRealizados daoServiciosRealizados = new DaoServiciosRealizados();

        public FormEliminarServicios()
        {
            InitializeComponent();
            daoServiciosRealizados.MostrarTodosServiciosRealizados(dgvServicios);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (servicioRealizadoSeleccionado != null)
            {
                if (daoServiciosRealizados.PuedeCancelarServicio(servicioRealizadoSeleccionado))
                {
                    daoServiciosRealizados.CancelarServicioRealizado(servicioRealizadoSeleccionado);
                    this.Close();
                }
                else
                    MessageBox.Show("El servicio no se puede cancelar porque ya ha sido realizado o cancelado.", "Cancelación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                // Mostramos un mensaje si no se ha seleccionado ninguna reserva
                MessageBox.Show("Por favor, seleccione un servicio para eliminar.", "Servicio no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nos aseguramos de que no sea la columna de encabezado
            {
                DataGridViewRow row = dgvServicios.Rows[e.RowIndex];

                int idServicioRealizado = Convert.ToInt32(row.Cells["id_servicio_realizado"].Value);
                int idServicioDisponible = Convert.ToInt32(row.Cells["id_servicio_disponible"].Value);
                int idHabitacion = Convert.ToInt32(row.Cells["id_habitacion"].Value);
                int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                decimal precioTotalServicios = Convert.ToDecimal(row.Cells["precio_total_servicios"].Value);
                DateTime? hecho = row.Cells["hecho"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["hecho"].Value) : (DateTime?)null;
                DateTime? fechaCancelacion = row.Cells["fecha_cancelacion"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["fecha_cancelacion"].Value) : (DateTime?)null;

                //int numeroPersonas = Convert.ToInt32(row.Cells["numero_personas"].Value);
                //decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                //string estado = row.Cells["estado"].Value.ToString();

                // Creamos el objeto ServicioRealizado y se lo pasamos a la variable servicioRealizadoSeleccionado (nuevo formulario)
                servicioRealizadoSeleccionado = new ServicioRealizado(idServicioRealizado, idServicioDisponible, idHabitacion, cantidad, precioTotalServicios, hecho, fechaCancelacion);
            }
        }

        private void dgvServicios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Obtenemos el indice de la columna del DataGridView
            if (this.dgvServicios.Columns[e.ColumnIndex].Name == "hecho")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.LimeGreen;
                }
            }
            else if (this.dgvServicios.Columns[e.ColumnIndex].Name == "fecha_cancelacion")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
