using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_hotel.dto
{
    public class Reserva
    {
        //Implementamos métodos getter y setter.
        public int idReserva {  get; set; }
        public int idCliente { get; set; }
        public int idHabitacion { get; set; }
        public DateTime fechaEntrada { get; set; }
        public DateTime fechaSalida { get; set; }
        public decimal coste { get; set; }
        public int idEmpleado { get; set; }
        public DateTime fechaReserva { get; set; }
        public DateTime? fechaCancelacionReserva { get; set; }  // Acepta que sea nullable
        public string observaciones { get; set; }


        //Constructor con parámetros
        public Reserva(int idCliente, int idHabitacion, DateTime fechaEntrada, DateTime fechaSalida, decimal coste, int idEmpleado, DateTime fechaReserva, DateTime? fechaCancelacionReserva, string observaciones)
        {
            this.idCliente = idCliente;
            this.idHabitacion = idHabitacion;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.coste = coste;
            this.idEmpleado = idEmpleado;
            this.fechaReserva = fechaReserva;
            this.fechaCancelacionReserva = fechaCancelacionReserva;
            this.observaciones = observaciones;
        }

        //Constructor con parámetros con idReserva
        public Reserva(int idReserva, int idCliente, int idHabitacion, DateTime fechaEntrada, DateTime fechaSalida, decimal coste, int idEmpleado, DateTime fechaReserva, DateTime? fechaCancelacionReserva, string observaciones)
        {
            this.idReserva = idReserva;
            this.idCliente = idCliente;
            this.idHabitacion = idHabitacion;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.coste = coste;
            this.idEmpleado = idEmpleado;
            this.fechaReserva = fechaReserva;
            this.fechaCancelacionReserva = fechaCancelacionReserva;
            this.observaciones = observaciones;
        }
    }
}
