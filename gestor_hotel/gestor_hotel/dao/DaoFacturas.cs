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
    internal class DaoFacturas
    {
        DaoClientes daoClientes = new DaoClientes();
        DaoReservas daoReservas = new DaoReservas();

        // Método para listar todas las facturas en un DataGridView
        public void ListarDatos(DataGridView dgvFacturas)
        {
            string query = "SELECT * FROM facturas";

            try
            {
                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = myCommand;
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvFacturas.DataSource = dataTable;

                dgvFacturas.ReadOnly = true;
                dgvFacturas.AllowUserToAddRows = false;
                dgvFacturas.AllowUserToDeleteRows = false;

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

        public void CrearFacturaInicial(int idCliente, decimal coste)
        {
            int idReserva = daoReservas.ObtenerUltimoIdReserva();
            string direccionFacturacion = daoClientes.ObtenerDireccionFacturacion(idCliente);
            try
            {
                string query = "INSERT INTO facturas (numero_factura, fecha, id_cliente, precio_total,  id_servicio_realizado, id_servicio_disponible, id_reserva, direccion_facturacion, cantidad_pagada, estado, metodo_pago) " +
                               "VALUES (@numeroFactura, @fecha, @idCliente, @precioTotal, @idServicioRealizado, @idServicioDisponible, @idReserva, @direccionFacturacion, @cantidadPagada, @estado, @metodoPago)";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@numeroFactura", ObtenerSiguienteNumeroFactura());   // Método para agregar el siguiente numero_factura
                myCommand.Parameters.AddWithValue("@fecha", DateTime.Now);
                myCommand.Parameters.AddWithValue("@idCliente", idCliente);
                myCommand.Parameters.AddWithValue("@precioTotal", coste);   // Se actualizará más tarde
                myCommand.Parameters.AddWithValue("@idServicioRealizado", 1);   // Se actualizará más tarde
                myCommand.Parameters.AddWithValue("@idServicioDisponible", 1);  // Se actualizará más tarde
                myCommand.Parameters.AddWithValue("@idReserva", idReserva);
                myCommand.Parameters.AddWithValue("@direccionFacturacion", direccionFacturacion);
                myCommand.Parameters.AddWithValue("@cantidadPagada", 0);
                myCommand.Parameters.AddWithValue("@estado", "Pendiente");
                myCommand.Parameters.AddWithValue("@metodoPago", "");   // Se actualizará más tarde                                                                                     

                myCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al crear la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int ObtenerSiguienteNumeroFactura()
        {
            int siguienteNumeroFactura = 1;
            string query = "SELECT MAX(numero_factura) FROM facturas";

            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conexion);

                object result = myCommand.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    siguienteNumeroFactura = Convert.ToInt32(result) + 1;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener el siguiente número de factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente número de factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return siguienteNumeroFactura;
        }

        public int ObtenerIdFacturaPorReserva(int idHabitacion)
        {
            int idFactura = 0;
            try
            {
                string query = "SELECT id_factura FROM facturas WHERE id_reserva = (SELECT id_reserva FROM reservas WHERE id_habitacion = @idHabitacion ORDER BY fecha_reserva DESC LIMIT 1)";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                MySqlCommand myCommand = new MySqlCommand(query, conexion);
                myCommand.Parameters.AddWithValue("@idHabitacion", idHabitacion);

                if (conexion.State == ConnectionState.Open)
                {
                    idFactura = Convert.ToInt32(myCommand.ExecuteScalar());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al obtener el id de la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el id de la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return idFactura;
        }

        public void ActualizarFactura(int idFactura, int idServicioRealizado, int idServicioDisponible, decimal precioTotalServicios)
        {
            try
            {
                // Obtener el precio total actual de la factura
                string selectQuery = "SELECT precio_total FROM facturas WHERE id_factura = @idFactura";

                Conexion objetoConexion = new Conexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();
                decimal precioTotalActual = 0;

                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conexion);
                selectCommand.Parameters.AddWithValue("@idFactura", idFactura);

                using (MySqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        precioTotalActual = reader.GetDecimal("precio_total");
                    }
                }

                decimal nuevoPrecioTotal = precioTotalActual + precioTotalServicios;

                // Actualizar la factura con el nuevo precio total y los IDs correspondientes
                string updateQuery = "UPDATE facturas SET id_servicio_realizado = @idServicioRealizado, id_servicio_disponible = @idServicioDisponible, precio_total = @nuevoPrecioTotal " +
                                     "WHERE id_factura = @idFactura";

                MySqlCommand updateCommand = new MySqlCommand(updateQuery, conexion);
                updateCommand.Parameters.AddWithValue("@idServicioRealizado", idServicioRealizado);
                updateCommand.Parameters.AddWithValue("@idServicioDisponible", idServicioDisponible);
                updateCommand.Parameters.AddWithValue("@nuevoPrecioTotal", nuevoPrecioTotal);
                updateCommand.Parameters.AddWithValue("@idFactura", idFactura);

                if (conexion.State == ConnectionState.Open)
                {
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Factura actualizada con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL al actualizar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
