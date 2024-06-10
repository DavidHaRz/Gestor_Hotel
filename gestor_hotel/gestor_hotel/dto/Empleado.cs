using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_hotel.dto
{
    public class Empleado
    {
        //Implementamos métodos getter y setter.
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string puesto { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public byte disponible { get; set; }
        public int id_servicio_disponible{ get; set; }


        //Constructor
        public Empleado(string nombre, string apellidos, string puesto, string usuario, string contrasena, byte disponible, int id_servicio_disponible)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.puesto = puesto;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.disponible = disponible;
            this.id_servicio_disponible = id_servicio_disponible;
        }

        //Constructor para inicio sesión
        public Empleado(int id_empleado, string nombre, string puesto)
        {
            this.id_empleado = id_empleado;
            this.nombre = nombre;
            this.puesto = puesto;
        }
    }
}
