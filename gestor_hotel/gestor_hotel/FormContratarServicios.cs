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
    public partial class FormContratarServicios : Form
    {
        private DaoHabitaciones daoHabitaciones = new DaoHabitaciones();
        private DaoServiciosRealizados daoServiciosRealizados = new DaoServiciosRealizados();
        private ServicioDisponible _servicioDisponible;   // Variable privada
        // Constructor que recibe un objeto ServicioDisponible
        public FormContratarServicios(ServicioDisponible servicioDisponible)
        {
            InitializeComponent();
            _servicioDisponible = servicioDisponible;
            daoHabitaciones.ActualizarEstadoHabitaciones(dgvHabitaciones);
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
                                e.CellStyle.BackColor = Color.Lime;
                                break;
                            case "ocupado":
                                //e.CellStyle.ForeColor = Color.Red;
                                e.CellStyle.BackColor = Color.Red;
                                break;
                            case "reservada":
                                //e.CellStyle.ForeColor = Color.Blue;
                                e.CellStyle.BackColor = Color.Orange;
                                break;
                            case "bloqueada":
                                e.CellStyle.ForeColor = Color.Red;
                                e.CellStyle.BackColor = Color.Black;
                                break;
                            default:
                                break;
                        }

                    }
                }
                catch (NullReferenceException ex) { MessageBox.Show("" + ex); }
            }
        }

        private void dgvHabitaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nos aseguramos de que no sea la columna de encabezado
            {
                DataGridViewRow row = dgvHabitaciones.Rows[e.RowIndex];

                int idHabitacion = Convert.ToInt32(row.Cells["id_habitacion"].Value);
                string numeroHabitacion = row.Cells["numero_habitacion"].Value.ToString();
                //int numeroPersonas = Convert.ToInt32(row.Cells["numero_personas"].Value);
                //decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                //string estado = row.Cells["estado"].Value.ToString();

                // Mostrar un mensaje de confirmación
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea contratar el servicio " + _servicioDisponible.nombre + " a la habitación " + numeroHabitacion + "?", "Confirmar contratación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si confirmamos el servicio se aplicará a la habitacíon seleccionada
                if (resultado == DialogResult.Yes)
                {
                    daoServiciosRealizados.ContratarServicio(_servicioDisponible.idServicioDisponible, idHabitacion, 1, (_servicioDisponible.precioServicioDisponible*1), null, null);
                    this.Close();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
