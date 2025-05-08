using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TP6_GRUPO_11
{
    public class accesoDatos
    {
        string rutaNeptuno = "Data Source=DESKTOP-6LDIHKB\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public accesoDatos()
        {
            // Constructor de la clase accesoDatos
        }
        public SqlConnection ObtenerConexion()
        {
                SqlConnection connection = new SqlConnection(rutaNeptuno);
                try
            {
                connection.Open();
                return connection;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public SqlDataAdapter ObtenerDataAdapter(string consultaSQL)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL, ObtenerConexion());
                return dataAdapter;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public int EjecutarProcedimientosAlmacenados(SqlCommand comandoSQL, string nombreProcedimientoAlmacenado)
        {
            int filasAfectadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand = comandoSQL;
            sqlCommand.Connection = Conexion;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure; ///ACÁ SE INDICA QUE ES UN PROCEDIMIENTO ALMACENADO
            sqlCommand.CommandText = nombreProcedimientoAlmacenado; ///ACÁ SE INDICA EL NOMBRE DEL PROCEDIMIENTO ALMACENADO
            filasAfectadas = sqlCommand.ExecuteNonQuery();  ///ACÁ SE EJECUTA EL PROCEDIMIENTO ALMACENADO
            Conexion.Close();
            return filasAfectadas;
        }
    }
}