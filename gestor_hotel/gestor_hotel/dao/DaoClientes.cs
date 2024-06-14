using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using gestor_hotel.dto;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace gestor_hotel.dao
{
    internal class DaoClientes
    {
        // Método para listar todos los clientes en un DataGridView
        public void ListarDatos(DataGridView dgvClientes)
        {
            string query = "SELECT * FROM clientes";

            try
            {
                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = myCommand;
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvClientes.DataSource = dataTable;

                dgvClientes.ReadOnly = true;
                dgvClientes.AllowUserToAddRows = false;
                dgvClientes.AllowUserToDeleteRows = false;

                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al listar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para añadir clientes a la base de datos
        public void CrearCliente(Cliente cliente)
        {
            try
            {
                string query = "INSERT INTO clientes (nombre, apellidos, dni, telefono, email, direccion_facturacion, observaciones) " +
                               "VALUES (@nombre, @apellidos, @dni, @telefono, @email, @direccionFacturacion, @observaciones)";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@nombre", cliente.nombre);
                myCommand.Parameters.AddWithValue("@apellidos", cliente.apellidos);
                myCommand.Parameters.AddWithValue("@dni", cliente.dni);
                myCommand.Parameters.AddWithValue("@telefono", cliente.telefono);
                myCommand.Parameters.AddWithValue("@email", cliente.email);
                myCommand.Parameters.AddWithValue("@direccionFacturacion", cliente.direccionFacturacion);
                myCommand.Parameters.AddWithValue("@observaciones", cliente.observaciones);

                if (conexion.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Cliente creado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al añadir el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para eliminar un cliente por DNI
        public void EliminarCliente(string dni)
        {
            try
            {
                string query = "DELETE FROM clientes WHERE dni = @dni";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@dni", dni);

                if (conexion.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Cliente eliminado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para modificar la información de un cliente
        public void ModificarCliente(string nombre, string apellidos, string dni, string telefono, string email, string direccionFacturacion, string observaciones)
        {
            try
            {
                string query = "UPDATE clientes SET nombre = @nombre, apellidos = @apellidos, telefono = @telefono, " +
                               "email= @email, direccion_facturacion = @direccionFacturacion, observaciones = @observaciones WHERE dni = @dni";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@nombre", nombre);
                myCommand.Parameters.AddWithValue("@apellidos", apellidos);
                myCommand.Parameters.AddWithValue("@dni", dni);
                myCommand.Parameters.AddWithValue("@telefono", telefono);
                myCommand.Parameters.AddWithValue("@email", email);
                myCommand.Parameters.AddWithValue("@direccionFacturacion", direccionFacturacion);
                myCommand.Parameters.AddWithValue("@observaciones", observaciones);

                if (conexion.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("¡Cliente modificado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Método para comprabar si el cliente existe
        public bool ClienteExiste(int idCliente)
        {
            bool existe = false;
            try
            {
                string query = "SELECT COUNT(*) FROM clientes WHERE id_cliente = @idCliente";
                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idCliente", idCliente);

                int count = Convert.ToInt32(myCommand.ExecuteScalar());

                // Si count es mayor que 0, significa que el cliente existe
                existe = count > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return existe;
        }

        public string ObtenerDireccionFacturacion(int idCliente)
        {
            string direccionFacturacion = string.Empty;
            string query = "SELECT direccion_facturacion FROM clientes WHERE id_cliente = @idCliente";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idCliente", idCliente);

                using (MySqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        direccionFacturacion = reader["direccion_facturacion"].ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener la dirección de facturación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la dirección de facturación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return direccionFacturacion;
        }

        public Cliente ObtenerClientePorId(int idCliente)
        {
            Cliente cliente = null;
            string query = "SELECT * FROM clientes WHERE id_cliente = @idCliente";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();


            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idCliente", idCliente);

                using (MySqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32("id_cliente");
                        string nombre = reader.GetString("nombre");
                        string apellidos = reader.GetString("apellidos");
                        string dni = reader.GetString("dni");
                        string telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? null : reader.GetString("telefono");
                        string email = reader.GetString("email");
                        string direccionFacturacion = reader.IsDBNull(reader.GetOrdinal("direccion_facturacion")) ? null : reader.GetString("direccion_facturacion");
                        string observaciones = reader.IsDBNull(reader.GetOrdinal("observaciones")) ? null : reader.GetString("observaciones");

                        cliente = new Cliente(id, nombre, apellidos, dni, telefono, email, direccionFacturacion, observaciones);

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la obtener el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return cliente;
        }

    }
}
