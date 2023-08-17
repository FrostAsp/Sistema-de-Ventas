using MySql.Data.MySqlClient;
using SisVentas.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentas.Datos
{
    public class D_Usuarios
    {
        public DataTable Login_us(string cLogin_us,string cPassword)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_login_us", SqlCon);
                Comando.CommandType= CommandType.StoredProcedure;
                Comando.Parameters.Add("cLogin_us",MySqlDbType.VarChar).Value= cLogin_us;
                Comando.Parameters.Add("cPassword_us", MySqlDbType.VarChar).Value = cPassword;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(SqlCon.State==ConnectionState.Open) SqlCon.Close();
            }

        }

        public DataTable Listado_us(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_listado_us", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;                
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }

        public DataTable Listado_ru()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_listado_ru", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;               
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }

        public string Guardar_us(int nOpcion,E_Usuarios oPro)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_guardar_us", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion",MySqlDbType.Int32).Value= nOpcion;
                Comando.Parameters.Add("nCodigo_us", MySqlDbType.Int32).Value = oPro.Codigo_us;
                Comando.Parameters.Add("cLogin_us", MySqlDbType.VarChar).Value = oPro.Login_us;
                Comando.Parameters.Add("cPassword_us", MySqlDbType.VarChar).Value = oPro.Password_us;
                Comando.Parameters.Add("cNombre_us", MySqlDbType.VarChar).Value = oPro.Nombre_us;
                Comando.Parameters.Add("nCodigo_ru", MySqlDbType.Int32).Value = oPro.Codigo_ru;
                
                MySqlParameter ParCodigo= new MySqlParameter();
                ParCodigo.ParameterName = "nCodigo_ou";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParCodigo);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Activo_us(int nCodigo_us)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_activo_us", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nCodigo_us", MySqlDbType.Int32).Value = nCodigo_us;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se realizó el proceso";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
