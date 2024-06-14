using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace gestor_hotel.dao
{
    internal class DaoRegistroEmpleados
    {
        // Método para crear registros de los empleados
        public void RegistrarEmpleado(int idEmpleado)
        {
            DateTime fechaHoy = DateTime.Now; // Guardamos la fecha y la hora actual

            // Consulta para verificar si ya existe un registro para el empleado hoy
            string queryCheck = "SELECT COUNT(*) FROM registro_empleados WHERE id_empleado = @idEmpleado AND DATE(fecha_entrada) = @fechaHoy AND fecha_salida IS NULL";

            // Consulta para insertar un nuevo registro
            string queryInsert = "INSERT INTO registro_empleados (id_empleado, fecha_entrada, fecha_salida) VALUES (@idEmpleado, @fechaHoy, NULL)";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand commandCheck = new MySqlCommand(queryCheck, conexion);
                commandCheck.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                commandCheck.Parameters.AddWithValue("@fechaHoy", fechaHoy.Date); // Solo la fecha para la comparación

                int count = Convert.ToInt32(commandCheck.ExecuteScalar());

                if (count == 0)
                {
                    MySqlCommand commandInsert = new MySqlCommand(queryInsert, conexion);
                    commandInsert.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    commandInsert.Parameters.AddWithValue("@fechaHoy", fechaHoy); // Fecha y hora para la inserción

                    commandInsert.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al registrar al empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar al empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close(); // Cierra la conexión
                }
            }
        }

        public void CerrarSesionEmpleado(int idEmpleado)
        {
            DateTime fechaHoy = DateTime.Now; // Incluye la fecha y la hora actuales

            // Consulta para actualizar el campo fecha_salida del registro de hoy
            string queryUpdate = "UPDATE registro_empleados SET fecha_salida = @fechaHoy " +
                                 "WHERE id_empleado = @idEmpleado AND DATE(fecha_entrada) = @fechaHoyDate";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, conexion);
                commandUpdate.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                commandUpdate.Parameters.AddWithValue("@fechaHoy", fechaHoy); // Fecha y hora para la actualización
                commandUpdate.Parameters.AddWithValue("@fechaHoyDate", fechaHoy.Date); // Solo la fecha para la comparación

                int rowsAffected = commandUpdate.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("No se encontró un registro de entrada para el empleado hoy.", "Cerrar sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al cerrar la sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close(); // Cierra la conexión
                }
            }
        }

    }
}
