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
        private Factura facturaSeleccionada;    // Variable privada
        int idEmpleado;
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
                int idServicioRealizado = Convert.ToInt32(row.Cells["id_servicio_realizado"].Value);
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
            // TODO
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            daoFacturas.ListarDatos(dgvFacturas);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
