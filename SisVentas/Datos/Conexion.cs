using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SisVentas.Datos
{
    public class Conexion
    {
        private string Basededatos;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Basededatos = "bd_ventas";
            this.Servidor = "localhost";
            this.Puerto = "3306";
            this.Usuario = "jason";
            this.Clave = "jason";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = "datasource=" + this.Servidor +
                                        ";port=" + this.Puerto +
                                        ";username=" + this.Usuario +
                                        ";password=" + this.Clave +
                                        ";Database=" + this.Basededatos;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
