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
        DaoFacturas daoFacturas = new DaoFacturas();
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

                    // Obtener el id_factura correspondiente a la reserva
                    int idFactura = daoFacturas.ObtenerIdFacturaPorReserva(id_habitacion);

                    // Actualizamos los campos en la factura
                    daoFacturas.ActualizarFactura(idFactura, ObtenerUltimoIdServicioRealizado(), id_servicio_disponible, precio_total_servicios);

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

        // Método para obtener todos los servicios realizados 
        public void MostrarTodosServiciosRealizados(DataGridView dgvTareas)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM servicios_realizados";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);

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

        // Método para cancelar el servicioRealizado
        public void CancelarServicioRealizado(ServicioRealizado servicioRealizado)
        {
            try
            {
                string query = "UPDATE servicios_realizados SET fecha_cancelacion = @fechaCancelacion WHERE id_servicio_realizado = @idServicioRealizado";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@fechaCancelacion", DateTime.Now); // Usamos la fecha y hora actual
                myCommand.Parameters.AddWithValue("@idServicioRealizado", servicioRealizado.idServicioRealizado);

                // Ejecutar la consulta si la conexión está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("¡Servicio cancelado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al cancelar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para comprobar si se puede cancelar un servicio
        public bool PuedeCancelarServicio(ServicioRealizado servicioRealizado)
        {
            bool puedeCancelar = false;

            string query = "SELECT hecho, fecha_cancelacion FROM servicios_realizados WHERE id_servicio_realizado = @idServicioRealizado";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idServicioRealizado", servicioRealizado.idServicioRealizado);

                using (MySqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        object hecho = reader["hecho"];
                        object fechaCancelacion = reader["fecha_cancelacion"];

                        if (hecho == DBNull.Value && fechaCancelacion == DBNull.Value)
                        {
                            puedeCancelar = true;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al comprobar si se puede cancelar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar si se puede cancelar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return puedeCancelar;
        }

        // Método para obtener el ultimo id_servicio_realizado
        public int ObtenerUltimoIdServicioRealizado()
        {
            int idServicioRealizado = 0;
            string query = "SELECT MAX(id_servicio_realizado) FROM servicios_realizados";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);

                object result = myCommand.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    idServicioRealizado = Convert.ToInt32(result);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener el último ID de servicios_realizados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el último ID de servicios_realizados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return idServicioRealizado;
        }

        // Método para obtener el servicio completo pasandole su id
        public ServicioRealizado ObtenerServicioRealizadoPorId(int idServicioRealizado)
        {
            ServicioRealizado servicioRealizado = null;
            try
            {
                string query = "SELECT id_servicio_realizado, id_servicio_disponible, id_habitacion, cantidad, precio_total_servicios, hecho, fecha_cancelacion " +
                               "FROM servicios_realizados " +
                               "WHERE id_servicio_realizado = @idServicioRealizado";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idServicioRealizado", idServicioRealizado);

                if (conexion.State == ConnectionState.Open)
                {
                    using (MySqlDataReader reader = myCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idServicioDisponible = reader.GetInt32("id_servicio_disponible");
                            int idHabitacion = reader.GetInt32("id_habitacion");
                            int cantidad = reader.GetInt32("cantidad");
                            decimal precioTotalServicios = reader.GetDecimal("precio_total_servicios");
                            DateTime? hecho = reader.IsDBNull(reader.GetOrdinal("hecho")) ? (DateTime?)null : reader.GetDateTime("hecho");
                            DateTime? fechaCancelacion = reader.IsDBNull(reader.GetOrdinal("fecha_cancelacion")) ? (DateTime?)null : reader.GetDateTime("fecha_cancelacion");

                            servicioRealizado = new ServicioRealizado(
                                idServicioRealizado,
                                idServicioDisponible,
                                idHabitacion,
                                cantidad,
                                precioTotalServicios,
                                hecho,
                                fechaCancelacion
                            );
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener el servicio realizado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el servicio realizado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return servicioRealizado;
        }

    }
}
