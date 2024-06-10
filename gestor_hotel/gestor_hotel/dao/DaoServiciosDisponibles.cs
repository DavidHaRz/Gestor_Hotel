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
    internal class DaoServiciosDisponibles
    {
        //// Método para crear un servicio
        //public void CrearServicio(string nombre, string descripcion, decimal coste)
        //{
        //    try
        //    {
        //        string query = "INSERT INTO servicios_disponibles (nombre, descripcion, coste) " +
        //                   "VALUES (@nombre, @descripcion, @coste)";

        //        Conexion objetoConexion = new Conexion();
        //        MySqlConnection conexion = objetoConexion.establecerConexion();


        //        MySqlCommand myCommand = new MySqlCommand(query, conexion);
        //        myCommand.Parameters.AddWithValue("@nombre", nombre);
        //        myCommand.Parameters.AddWithValue("@descripcion", descripcion);
        //        myCommand.Parameters.AddWithValue("@coste", coste);


        //        if (conexion.State == ConnectionState.Open)
        //        {
        //            myCommand.ExecuteNonQuery();
        //            MessageBox.Show("¡Servicio creado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Error de MySQL al crear el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al crear el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        // Método para listar todos los servicios en un DataGridView
        public void ListarDatos(DataGridView dgvServicios)
        {
            string query = "SELECT * FROM servicios_disponibles";

            try
            {
                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = myCommand;
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvServicios.DataSource = dataTable;

                dgvServicios.ReadOnly = true;
                dgvServicios.AllowUserToAddRows = false;
                dgvServicios.AllowUserToDeleteRows = false;

                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al listar los servicios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los servicios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int ObtenerIdServicioDisponiblePorEmpleado(int idEmpleado)
        {
            int idServicioDisponible = -1; // Valor por defecto si no se encuentra

            try
            {
                string query = "SELECT id_servicio_disponible FROM empleados WHERE id_empleado = @idEmpleado";
                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                object result = myCommand.ExecuteScalar();
                conexion.Close();

                if (result != null && result != DBNull.Value)
                {
                    idServicioDisponible = Convert.ToInt32(result);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener el ID del servicio disponible: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del servicio disponible: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return idServicioDisponible;
        }

    }
}
