using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_hotel.dto
{
    public class ServicioDisponible
    {
        //Implementamos métodos getter y setter.
        public int idServicioDisponible {  get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precioServicioDisponible { get; set; }


        //Constructor
        public ServicioDisponible(int idServicioDisponible, string nombre, string descripcion, decimal precioServicioDisponible)
        {
            this.idServicioDisponible = idServicioDisponible;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioServicioDisponible = precioServicioDisponible;
        }
    }
}
