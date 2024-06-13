using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using MySqlX.XDevAPI.Common;

namespace gestor_hotel.dao
{
    internal class DaoHabitaciones
    {

        // Método para listar todas las habitaciones en un DataGridView
        public void ListarDatos(DataGridView dgvHabitaciones)
        {
            string query = "SELECT * FROM habitaciones";

            try
            {
                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = myCommand;
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvHabitaciones.DataSource = dataTable;

                dgvHabitaciones.ReadOnly = true;
                dgvHabitaciones.AllowUserToAddRows = false;
                dgvHabitaciones.AllowUserToDeleteRows = false;

                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al listar las habitaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar las habitaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Comprobación de que la habitación existe
        public bool HabitacionExiste(int idHabitacion)
        {
            bool existe = false;
            try
            {
                string query = "SELECT COUNT(*) FROM habitaciones WHERE id_habitacion = @id";
                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@id", idHabitacion);

                int count = Convert.ToInt32(myCommand.ExecuteScalar());

                if (count > 0)
                {
                    existe = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al verificar la habitación: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la habitación: " + ex.Message);
            }
            return existe;
        }

        // Obtenemos el precio de la habitación
        public decimal ObtenerPrecioHabitacion(int idHabitacion)
        {
            decimal precio = 0m; // Valor predeterminado en caso de que no se encuentre el idHabitacion
            string query = "SELECT precio FROM habitaciones WHERE id_habitacion = @idHabitacion";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idHabitacion", idHabitacion);

                using (MySqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        precio = reader.GetDecimal("precio");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la habitación con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener el precio de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el precio de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close(); // Cierra la conexión si no está cerrada
                }
            }

            return precio;
        }

        // Método para modificar la información de una habitación
        public void ModificarHabitacion(int idHabitacion, string numeroHabitacion, int numeroPersonas, decimal precio, string estado)
        {
            try
            {
                string query = "UPDATE habitaciones SET numero_personas = @numeroPersonas, precio = @precio, estado = @estado WHERE id_habitacion = @idHabitacion && numero_habitacion = @numeroHabitacion";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                myCommand.Parameters.AddWithValue("@numeroHabitacion", numeroHabitacion);
                myCommand.Parameters.AddWithValue("@numeroPersonas", numeroPersonas);
                myCommand.Parameters.AddWithValue("@precio", precio);
                myCommand.Parameters.AddWithValue("@estado", estado);

                if (conexion.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("¡Habitación modificada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al modificar la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Método para modificar el estado de una habitación
        public void ModificarEstadoHabitacion(int idHabitacion, string estado)
        {
            try
            {
                string query = "UPDATE habitaciones SET estado = @estado WHERE id_habitacion = @idHabitacion";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                myCommand.Parameters.AddWithValue("@estado", estado);

                if (conexion.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    //MessageBox.Show("¡Estado de la habitación modificado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al modificar el estado de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el estado de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Listar y actualizar
        public void ActualizarEstadoHabitaciones(DataGridView dgvHabitaciones)
        {
            DateTime fechaHoy = DateTime.Now.Date;

            // Consulta para obtener el estado de las habitaciones basado en la fecha actual y el estado de las reservas
            string selectQuery = @"
                SELECT h.id_habitacion, h.numero_habitacion, numero_personas, precio,
                       CASE 
                           WHEN h.estado = 'bloqueada' THEN 'bloqueada'
                           WHEN r.fecha_cancelacion_reserva IS NOT NULL THEN 'libre'
                           WHEN r.fecha_entrada <= @fechaHoy AND r.fecha_salida >= @fechaHoy THEN 'ocupado'
                           WHEN r.fecha_entrada > @fechaHoy THEN 'reservada'
                           ELSE 'libre'
                       END AS estado
                FROM habitaciones h
                LEFT JOIN reservas r ON h.id_habitacion = r.id_habitacion AND r.fecha_cancelacion_reserva IS NULL
                GROUP BY h.id_habitacion, h.numero_habitacion, h.estado
            ";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conexion);
                selectCommand.Parameters.AddWithValue("@fechaHoy", fechaHoy);

                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Actualizar el estado de las habitaciones en la base de datos
                foreach (DataRow row in dt.Rows)
                {
                    int idHabitacion = Convert.ToInt32(row["id_habitacion"]);
                    string estado = row["estado"].ToString();

                    string updateQuery = "UPDATE habitaciones SET estado = @estado WHERE id_habitacion = @idHabitacion";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, conexion);
                    updateCommand.Parameters.AddWithValue("@estado", estado);
                    updateCommand.Parameters.AddWithValue("@idHabitacion", idHabitacion);

                    // Ejecutar la actualización
                    updateCommand.ExecuteNonQuery();
                }

                // Asignar el DataTable al DataGridView
                dgvHabitaciones.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al actualizar el estado de las habitaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado de las habitaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        // Obtenemos el estado de la habitación
        public string ObtenerEstadoHabitacion(int idHabitacion)
        {
            string estado = null;
            string query = "SELECT estado FROM habitaciones WHERE id_habitacion = @idHabitacion";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idHabitacion", idHabitacion);

                using (MySqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estado = reader["estado"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la habitación con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener el estado de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el estado de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close(); // Cierra la conexión si no está cerrada
                }
            }

            return estado;
        }

        // Comprobamos si una habitación está disponible para no hacer varias reservas de la misma habitación con fechas que se solapen
        public bool ComprobarDisponibilidadHabitacion(int idHabitacion, DateTime nuevaFechaEntrada, DateTime nuevaFechaSalida)
        {
            bool disponible = true;
            string query = @"
                SELECT fecha_entrada, fecha_salida 
                FROM reservas 
                WHERE id_habitacion = @idHabitacion 
                AND fecha_cancelacion_reserva IS NULL
                AND ((@nuevaFechaEntrada BETWEEN fecha_entrada AND fecha_salida)
                     OR (@nuevaFechaSalida BETWEEN fecha_entrada AND fecha_salida)
                     OR (fecha_entrada BETWEEN @nuevaFechaEntrada AND @nuevaFechaSalida)
                     OR (fecha_salida BETWEEN @nuevaFechaEntrada AND @nuevaFechaSalida))";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                myCommand.Parameters.AddWithValue("@nuevaFechaEntrada", nuevaFechaEntrada);
                myCommand.Parameters.AddWithValue("@nuevaFechaSalida", nuevaFechaSalida);

                using (MySqlDataReader reader = myCommand.ExecuteReader())
                {
                    // Si se encuentra alguna reserva en conflicto, la habitación no está disponible
                    if (reader.Read())
                    {
                        disponible = false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al comprobar la disponibilidad de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar la disponibilidad de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return disponible;

            }

        // Comprobar si la habitación está bloqueada
        public bool EsHabitacionBloqueada(int idHabitacion)
        {
            bool bloqueada = false;
            string query = "SELECT estado FROM habitaciones WHERE id_habitacion = @idHabitacion";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idHabitacion", idHabitacion);

                using (MySqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string estado = reader["estado"].ToString();
                        if (estado == "bloqueada")
                        {
                            bloqueada = true;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al comprobar el estado de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar el estado de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return bloqueada;
        }


    }
}
