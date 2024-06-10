using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestor_hotel.dto;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace gestor_hotel.dao
{
    internal class DaoServiciosRealizados
    {
        // Método para añadir servicios a la base de datos
        public void ContratarServicio(int id_servicio_disponible, int id_habitacion, int cantidad, decimal precio_total_servicios, DateTime? hecho, DateTime? fecha_cancelacion)
        {
            try
            {
                string query = "INSERT INTO servicios_realizados (id_servicio_disponible, id_habitacion, cantidad, precio_total_servicios, hecho, fecha_cancelacion) " +
                               "VALUES (@id_servicio_disponible, @id_habitacion, @cantidad, @precio_total_servicios, @hecho, @fecha_cancelacion)";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@id_servicio_disponible", id_servicio_disponible);
                myCommand.Parameters.AddWithValue("@id_habitacion", id_habitacion);
                myCommand.Parameters.AddWithValue("@cantidad", cantidad);
                myCommand.Parameters.AddWithValue("@precio_total_servicios", precio_total_servicios);
                myCommand.Parameters.AddWithValue("@hecho", (object)hecho ?? DBNull.Value);
                myCommand.Parameters.AddWithValue("@fecha_cancelacion", (object)fecha_cancelacion ?? DBNull.Value);

                if (conexion.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Servicio contratado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al contratar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contratar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para obtener los servicios realizados por empleado
        public void MostrarServiciosRealizados(DataGridView dgvTareas, int idEmpleado)
        {
            DaoServiciosDisponibles daoServiciosDisponibles = new DaoServiciosDisponibles();
            int idServicioDisponible = daoServiciosDisponibles.ObtenerIdServicioDisponiblePorEmpleado(idEmpleado);

            if (idServicioDisponible == -1)
            {
                MessageBox.Show("No se pudo encontrar el ID del servicio disponible para el empleado especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = new DataTable();

            try
            {
                //string query = "SELECT sr.id_servicio_realizado, sr.id_servicio_disponible, sr.id_habitacion, sr.cantidad, sr.precio_total_servicios, sr.hecho, sr.fecha_cancelacion " +
                string query = "SELECT sr.id_servicio_realizado, sr.id_servicio_disponible, sr.id_habitacion, h.numero_habitacion, sr.cantidad, sr.precio_total_servicios, sr.hecho, sr.fecha_cancelacion " +
                               "FROM servicios_realizados sr " +
                               "INNER JOIN habitaciones h ON sr.id_habitacion = h.id_habitacion " +
                               "WHERE sr.id_servicio_disponible = @idServicioDisponible";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idServicioDisponible", idServicioDisponible);

                MySqlDataAdapter adapter = new MySqlDataAdapter(myCommand);
                adapter.Fill(dt);

                dgvTareas.DataSource = dt; // Asigna el DataTable al DataGridView
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener los servicios realizados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los servicios realizados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para actualizar el estado del servicio realizado
        public void ActualizarServicioRealizado(ServicioRealizado servicio)
        {
            try
            {
                string query = "UPDATE servicios_realizados SET hecho = @hecho WHERE id_servicio_realizado = @idServicioRealizado";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idServicioRealizado", servicio.idServicioRealizado);
                myCommand.Parameters.AddWithValue("@hecho", servicio.hecho.HasValue ? (object)servicio.hecho.Value : DBNull.Value);

                myCommand.ExecuteNonQuery();
                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al actualizar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
