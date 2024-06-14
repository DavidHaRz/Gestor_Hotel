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
    public partial class FormFacturas : Form
    {
        DaoFacturas daoFacturas = new DaoFacturas();
        DaoServiciosRealizados daoServiciosRealizados = new DaoServiciosRealizados();
        private Factura facturaSeleccionada;    // Variable privada
        private ServicioRealizado servicioRealizado;    // Variable privada
        int idEmpleado;
        int idServicioRealizado;
        public FormFacturas()
        {
            InitializeComponent();
            daoFacturas.ListarDatos(dgvFacturas);
        }

        public FormFacturas(int id_empleado)
        {
            InitializeComponent();
            this.idEmpleado = id_empleado;
            daoFacturas.ListarDatos(dgvFacturas);

        }

        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nos aseguramos de que no sea la columna de encabezado
            {
                DataGridViewRow row = dgvFacturas.Rows[e.RowIndex];

                int idFactura = Convert.ToInt32(row.Cells["id_factura"].Value);
                int numeroFactura = Convert.ToInt32(row.Cells["numero_factura"].Value);
                DateTime fechaReserva = Convert.ToDateTime(row.Cells["fecha"].Value);
                int idCliente = Convert.ToInt32(row.Cells["id_cliente"].Value);
                decimal precioTotal = Convert.ToDecimal(row.Cells["precio_total"].Value);
                idServicioRealizado = Convert.ToInt32(row.Cells["id_servicio_realizado"].Value);
                int idServicioDisponible = Convert.ToInt32(row.Cells["id_servicio_disponible"].Value);
                int idReserva = Convert.ToInt32(row.Cells["id_reserva"].Value);
                string direccionFacturacion = row.Cells["direccion_facturacion"].Value.ToString();
                DateTime? fechaCancelacion = row.Cells["fecha_cancelacion"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["fecha_cancelacion"].Value) : (DateTime?)null;
                decimal cantidadPagada = Convert.ToDecimal(row.Cells["cantidad_pagada"].Value);
                string estado = row.Cells["estado"].Value.ToString();
                string metodoPago = row.Cells["metodo_pago"].Value.ToString();

                // Creamos el objeto Cliente y se lo pasamos a la variable clienteSeleccionado (nuevo formulario)
                facturaSeleccionada = new Factura(idFactura, numeroFactura, fechaReserva, idCliente, precioTotal, idServicioRealizado, idServicioDisponible, idReserva, direccionFacturacion, fechaCancelacion, cantidadPagada, estado, metodoPago);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (facturaSeleccionada != null)
            {
                if (daoFacturas.EsFacturaCancelada(facturaSeleccionada.idFactura) == false)
                {
                    // Mostrar un mensaje de confirmación
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar esta factura?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si confirmamos la factura, será cancelada
                    if (resultado == DialogResult.Yes)
                    {
                        // Cancelamos la factura
                        daoFacturas.CancelarFactura(facturaSeleccionada);
                        
                        // Actualizamos la lista
                        daoFacturas.ListarDatos(dgvFacturas);

                        // Cancelamos los servicios realizados de esa factura
                        servicioRealizado = daoServiciosRealizados.ObtenerServicioRealizadoPorId(idServicioRealizado);
                        if (daoServiciosRealizados.PuedeCancelarServicio(servicioRealizado))
                            daoServiciosRealizados.CancelarServicioRealizado(servicioRealizado);
                    }
                }
                else
                    MessageBox.Show("No se puede cancelar una factura cancelada.", "Factura cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                // Mostramos un mensaje si no se ha seleccionado ninguna reserva
                MessageBox.Show("Por favor, seleccione una factura para cancelar.", "Factura no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            daoFacturas.ListarDatos(dgvFacturas);
        }


        private FormImprimirFactura formImprimirFactura;    // Declarar el formulario como variable de clase
        private void btnPrepararFactura_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (facturaSeleccionada != null)
            {
                if (daoFacturas.EsFacturaCancelada(facturaSeleccionada.idFactura) == false)
                {
                    // Pasar el objeto servicio al nuevo formulario
                    formImprimirFactura = new FormImprimirFactura(facturaSeleccionada);    // Crear una nueva instancia
                    formImprimirFactura.Show();
                }
                else
                    MessageBox.Show("No se puede imprimir una factura cancelada.", "Factura cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                // Mostramos un mensaje si no se ha seleccionado ninguna reserva
                MessageBox.Show("Por favor, seleccione una factura para preparar.", "Factura no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void dgvFacturas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Obtenemos el indice de la columna del DataGridView
            if (this.dgvFacturas.Columns[e.ColumnIndex].Name == "fecha_cancelacion")
            {
                // Distinto de null
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                        e.CellStyle.BackColor = Color.Red;
                }
                catch (NullReferenceException ex) { MessageBox.Show("" + ex); }
            }

            // Obtenemos el indice de la columna del DataGridView
            if (this.dgvFacturas.Columns[e.ColumnIndex].Name == "estado")
            {
                // Distinto de null
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        switch (Convert.ToString(e.Value))
                        {
                            case "Pagada":
                                e.CellStyle.BackColor = Color.Lime;
                                break;
                            case "Pendiente":
                                e.CellStyle.BackColor = Color.Red;
                                break;
                            case "Parcial":
                                e.CellStyle.BackColor = Color.Orange;
                                break;
                            default:
                                break;
                        }
                    }
                        
                }
                catch (NullReferenceException ex) { MessageBox.Show("" + ex); }
            }
        }

        private void CerrarFormularios()
        {
            // Verificar si hay un formulario abierto y cerrarlo si es necesario
            if (formImprimirFactura != null && !formImprimirFactura.IsDisposed)
            {
                formImprimirFactura.Close();
                formImprimirFactura.Dispose();    // Liberar recursos asociados al formulario anterior
            }
        }
    }
}
