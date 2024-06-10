using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_hotel.dto
{
    public class RegistroEmpleado
    {
        //Implementamos métodos getter y setter.
        public int idEmpleado { get; set; }
        public DateTime fechaEntrada { get; set; }
        public DateTime fechaSalida { get; set; }


        //Constructor
        public RegistroEmpleado(int idEmpleado, DateTime fechaEntrada, DateTime fechaSalida)
        {
            this.idEmpleado = idEmpleado;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
        }
    }
}
