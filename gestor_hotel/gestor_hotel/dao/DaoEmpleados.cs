using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using gestor_hotel.dto;

namespace gestor_hotel.dao
{
    internal class DaoEmpleados
    {
        public Empleado IniciarSesion(string usuario, string contrasena)
        {
            Empleado empleado = null;
            string query = "SELECT id_empleado, nombre, puesto FROM empleados WHERE usuario = @usuario AND contrasena = @contrasena";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();


            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@usuario", usuario);
                myCommand.Parameters.AddWithValue("@contrasena", contrasena);

                using (MySqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id_empleado = reader.GetInt32("id_empleado");
                        string nombre = reader.GetString("nombre");
                        string puesto = reader.GetString("puesto");
                        empleado = new Empleado(id_empleado, nombre, puesto);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close(); // Cierra la conexión si no está cerrada
                }
            }
            return empleado;
        }
    }
}
