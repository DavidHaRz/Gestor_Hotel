using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gestor_hotel.dto
{
    public class Cliente
    {
        //Implementamos métodos getter y setter.
        public int idCliente {  get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string direccionFacturacion { get; set; }
        public string observaciones { get; set; }


        //Constructor con parámetros
        public Cliente(int idCliente, string nombre, string apellidos, string dni, string telefono, string email, string direccionFacturacion, string observaciones)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
            this.email = email;
            this.direccionFacturacion = direccionFacturacion;
            this.observaciones = observaciones;
        }

        public Cliente(string nombre, string apellidos, string dni, string telefono, string email, string direccionFacturacion, string observaciones)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
            this.email = email;
            this.direccionFacturacion = direccionFacturacion;
            this.observaciones = observaciones;
        }
    }
}
