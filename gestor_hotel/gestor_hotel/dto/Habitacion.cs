using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_hotel.dto
{
    public class Habitacion
    {
        //Implementamos métodos getter y setter.
        public int idHabitacion { get; set; }
        public string numeroHabitacion { get; set; }
        public int numeroPersonas { get; set; }
        public decimal precio { get; set; }
        public string estado { get; set; }


        ////Constructor con parámetros
        public Habitacion(string numeroHabitacion, int numeroPersonas, decimal precio, string estado)
        {
            this.numeroHabitacion = numeroHabitacion;
            this.numeroPersonas = numeroPersonas;
            this.precio = precio;
            this.estado = estado;
        }

        // Constructor para poder comprobar que la habitación existe
        public Habitacion(int idHabitacion)
        {
            this.idHabitacion = idHabitacion;
        }

        //Constructor con parámetros para poder modificar
        public Habitacion(int idHabitacion, string numeroHabitacion, int numeroPersonas, decimal precio, string estado)
        {
            this.idHabitacion = idHabitacion;
            this.numeroHabitacion = numeroHabitacion;
            this.numeroPersonas = numeroPersonas;
            this.precio = precio;
            this.estado = estado;
        }
    }
    }
