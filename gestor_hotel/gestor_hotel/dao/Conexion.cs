using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace gestor_hotel.dao
{
    internal class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();
        static string servidor = "localhost";
        static string db = "gestor_hotel";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";
        string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario
        + "; password=" + password + "; database=" + db + ";";
        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                //MessageBox.Show("Se conectó a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos, error: " + ex.ToString());
            }
            return conexion;
        }
        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
