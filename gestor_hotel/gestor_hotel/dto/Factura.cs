using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_hotel.dto
{
    public class Factura
    {
        //Implementamos métodos getter y setter.
        public int numeroFactura { get; set; }
        public DateTime fecha { get; set; }
        public int idCliente { get; set; }
        public decimal precioTotal { get; set; }
        public int idServicioRealizado { get; set; }
        public int idServicioDisponible { get; set; }
        public int idReserva { get; set; }
        public string direccionFacturacion { get; set; }
        public DateTime fechaCancelacion { get; set; }
        public decimal cantidadPagada { get; set; }
        public string estado { get; set; }
        public string metodoPago { get; set; }


        //Constructor
        public Factura(int numeroFactura, DateTime fecha, int idCliente, decimal precioTotal, int idServicioRealizado, int idServicioDisponible, int idReserva, string direccionFacturacion, DateTime fechaCancelacion, decimal cantidadPagada, string estado, string metodoPago)
        {
            this.numeroFactura = numeroFactura;
            this.fecha = fecha;
            this.idCliente = idCliente;
            this.precioTotal = precioTotal;
            this.idServicioRealizado = idServicioRealizado;
            this.idServicioDisponible = idServicioDisponible;
            this.idReserva = idReserva;
            this.direccionFacturacion = direccionFacturacion;
            this.fechaCancelacion = fechaCancelacion;
            this.cantidadPagada = cantidadPagada;
            this.estado = estado;
            this.metodoPago = metodoPago;
        }
    }
}
