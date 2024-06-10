using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_hotel.dto
{
    public class ServicioRealizado
    {
        //Implementamos métodos getter y setter.
        public int idServicioRealizado{ get; set; }
        public int idServicioDisponible { get; set; }
        public int idHabitacion { get; set; }
        public int cantidad { get; set; }
        public decimal precioTotalServicios { get; set; }
        public DateTime? hecho { get; set; }
        public DateTime? fechaCancelacion { get; set; }


        //Constructor
        public ServicioRealizado(int idServicioRealizado, int idServicioDisponible, int idHabitacion, int cantidad, decimal precioTotalServicios, DateTime? hecho, DateTime? fechaCancelacion)
        {
            this.idServicioRealizado = idServicioRealizado;
            this.idServicioDisponible = idServicioDisponible;
            this.idHabitacion = idHabitacion;
            this.cantidad = cantidad;
            this.precioTotalServicios = precioTotalServicios;
            this.hecho = hecho;
            this.fechaCancelacion = fechaCancelacion;
        }
    }
}
