using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using gestor_hotel.dto;

namespace gestor_hotel.dao
{
    internal class DaoReservas
    {
        DaoHabitaciones daoHabitaciones = new DaoHabitaciones();
        // Método para listar todas las reservas en un DataGridView
        public void ListarDatos(DataGridView dgvReservas)
        {
            string query = "SELECT * FROM reservas";

            try
            {
                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = myCommand;
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvReservas.DataSource = dataTable;

                dgvReservas.ReadOnly = true;
                dgvReservas.AllowUserToAddRows = false;
                dgvReservas.AllowUserToDeleteRows = false;

                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al listar las reservas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar las reservas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cancelar una reserva (se pondrá la fecha actual en fechaCancelacionReserva
        public void CancelarReserva(Reserva reserva)
        {
            try
            {
                // Consulta SQL para actualizar solo la fecha_cancelacion_reserva con múltiples condiciones
                string query = "UPDATE reservas SET fecha_cancelacion_reserva = @fechaCancelacionReserva " +
                               "WHERE id_cliente = @idCliente AND id_habitacion = @idHabitacion " +
                               "AND fecha_entrada = @fechaEntrada AND fecha_salida = @fechaSalida " +
                               "AND id_empleado = @idEmpleado AND fecha_reserva = @fechaReserva";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@fechaCancelacionReserva", DateTime.Now); // Usamos la fecha y hora actual
                myCommand.Parameters.AddWithValue("@idCliente", reserva.idCliente);
                myCommand.Parameters.AddWithValue("@idHabitacion", reserva.idHabitacion);
                myCommand.Parameters.AddWithValue("@fechaEntrada", reserva.fechaEntrada);
                myCommand.Parameters.AddWithValue("@fechaSalida", reserva.fechaSalida);
                myCommand.Parameters.AddWithValue("@coste", reserva.coste);
                myCommand.Parameters.AddWithValue("@idEmpleado", reserva.idEmpleado);
                myCommand.Parameters.AddWithValue("@fechaReserva", reserva.fechaReserva);

                // Ejecutar la consulta si la conexión está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("¡Reserva cancelada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al cancelar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para crear una reserva
        public bool CrearReserva(int idCliente, int idHabitacion, DateTime fechaEntrada, DateTime fechaSalida, decimal coste, int idEmpleado, DateTime fechaReserva, DateTime? fechaCancelacionReserva, string observaciones)
        {
            bool funciona = false;
            try
            {
                string query = "INSERT INTO reservas (id_cliente, id_habitacion, fecha_entrada, fecha_salida, coste, id_empleado, fecha_reserva, fecha_cancelacion_reserva, observaciones) " +
                           "VALUES (@idCliente, @idHabitacion, @fechaEntrada, @fechaSalida, @coste, @idEmpleado, @fechaReserva, @fechaCancelacionReserva, @observaciones)";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();


                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idCliente", idCliente);
                myCommand.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                myCommand.Parameters.AddWithValue("@fechaEntrada", fechaEntrada);
                myCommand.Parameters.AddWithValue("@fechaSalida", fechaSalida);
                myCommand.Parameters.AddWithValue("@coste", coste);
                myCommand.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                myCommand.Parameters.AddWithValue("@fechaReserva", fechaReserva);
                myCommand.Parameters.AddWithValue("@fechaCancelacionReserva", (object)fechaCancelacionReserva ?? DBNull.Value);
                myCommand.Parameters.AddWithValue("@observaciones", observaciones);


                if (conexion.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("¡Reserva creada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funciona = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al crear la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return funciona;
        }
        
        public bool ModificarReserva(int idReserva, int idCliente, int idHabitacion, DateTime fechaEntrada, DateTime fechaSalida, decimal coste, DateTime fechaReserva, string observaciones)
        {
            bool funciona = false;
            try
            {
                string query = "UPDATE reservas SET fecha_entrada = @fechaEntrada, fecha_salida = @fechaSalida, " +
                               "coste = @coste, fecha_reserva = @fechaReserva, observaciones = @observaciones " +
                               "WHERE id_reserva = @idReserva";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idReserva", idReserva);
                myCommand.Parameters.AddWithValue("@idCliente", idCliente);
                myCommand.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                myCommand.Parameters.AddWithValue("@fechaEntrada", fechaEntrada);
                myCommand.Parameters.AddWithValue("@fechaSalida", fechaSalida);
                myCommand.Parameters.AddWithValue("@coste", coste);
                myCommand.Parameters.AddWithValue("@fechaReserva", fechaReserva);
                myCommand.Parameters.AddWithValue("@observaciones", observaciones);

                if (conexion.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("¡Reserva modificada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funciona = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al modificar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return funciona;
        }
       
        public bool EsReservaCancelada(int idReserva)
        {
            bool cancelada = false;
            try
            {
                string query = "SELECT fecha_cancelacion_reserva FROM reservas WHERE id_reserva = @idReserva";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idReserva", idReserva);

                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                object result = myCommand.ExecuteScalar();
                conexion.Close();

                if (result != DBNull.Value && result != null)
                {
                    cancelada = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al comprobar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return cancelada;
        }
        
        public int ObtenerUltimoIdReserva()
        {
            int idReserva = 0;
            string query = "SELECT MAX(id_reserva) FROM reservas";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);

                object result = myCommand.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    idReserva = Convert.ToInt32(result);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener el último ID de reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el último ID de reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return idReserva;
        }

        public Reserva ObtenerReservaPorId(int idReserva)
        {
            Reserva reserva = null;
            string query = "SELECT * FROM reservas WHERE id_reserva = @idReserva";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();


            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idReserva", idReserva);

                using (MySqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32("id_reserva");
                        int idCliente = reader.GetInt32("id_cliente");
                        int idHabitacion = reader.GetInt32("id_habitacion");
                        DateTime fechaEntrada = reader.GetDateTime("fecha_entrada");
                        DateTime fechaSalida = reader.GetDateTime("fecha_salida");
                        decimal coste = reader.GetDecimal("coste");
                        int idEmpleado = reader.GetInt32("id_empleado");
                        DateTime fechaReserva = reader.GetDateTime("fecha_reserva");
                        DateTime? fechaCancelacionReserva = reader.IsDBNull(reader.GetOrdinal("fecha_cancelacion_reserva")) ? (DateTime?)null : reader.GetDateTime("fecha_cancelacion_reserva");
                        string observaciones = reader.IsDBNull(reader.GetOrdinal("observaciones")) ? null : reader.GetString("observaciones");

                        reserva = new Reserva(id, idCliente, idHabitacion, fechaEntrada, fechaSalida, coste, idEmpleado, fechaReserva, fechaCancelacionReserva, observaciones);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la obtener la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return reserva;
        }
    }
}
