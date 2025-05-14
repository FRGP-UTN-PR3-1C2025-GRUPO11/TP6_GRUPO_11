using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_11.Conexion
{
    public class gestionNeptuno
    {
        public gestionNeptuno()
        {
            // Constructor de la clase gestionNeptuno
        }

    private DataTable ObtenerTabla(string nombreTabla, string consultaSQL)
        {
            DataSet dataSet = new DataSet();
            accesoDatos accesoDatos = new accesoDatos();
            SqlDataAdapter dataAdapter = accesoDatos.ObtenerDataAdapter(consultaSQL);
            dataAdapter.Fill(dataSet, nombreTabla);
            return dataSet.Tables[nombreTabla];
        }

        public DataTable ObtenerProductos()
        {
            //DataTable tabla = ObtenerTabla("Productos", "SELECT TOP 10 * FROM Productos");
            //tabla.Columns["IdProducto"].ColumnName = "ID Producto";
            //tabla.Columns["NombreProducto"].ColumnName = "Nombre Producto";
            //tabla.Columns["IdProveedor"].ColumnName = "Id Proveedor";
            //tabla.Columns["IdCategoría"].ColumnName = "Id Categoría";
            //tabla.Columns["CantidadPorUnidad"].ColumnName = "Cantidad Por Unidad";
            //tabla.Columns["PrecioUnidad"].ColumnName = "Precio Unidad";
            //tabla.Columns["UnidadesEnExistencia"].ColumnName = "Unidades en Existencia";
            //tabla.Columns["UnidadesEnPedido"].ColumnName = "Unidades en Pedido";
            //tabla.Columns["NivelNuevoPedido"].ColumnName = "Nivel nuevo Pedido";

            //return tabla;

            return ObtenerTabla("Productos", "SELECT * FROM Productos");
        }

        private void ArmarParametrosProducto(ref SqlCommand comando, Producto producto)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            sqlParametros.Value = producto.IdProducto;
            sqlParametros = comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 40);
            sqlParametros.Value = producto.NombreProducto;
            sqlParametros = comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.NVarChar, 20);
            sqlParametros.Value = producto.CantidadPorUnidad;
            sqlParametros = comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
            sqlParametros.Value = producto.PrecioUnidad;
        }

        public bool ActualizarProducto(Producto producto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ArmarParametrosProducto(ref sqlCommand, producto);
            accesoDatos acceso = new accesoDatos();
            int FilasInsertadas = acceso.EjecutarProcedimientosAlmacenados(sqlCommand, "psActualizarProducto");
            if (FilasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ArmarParametrosProductoEliminar(ref SqlCommand Comando, Producto producto)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = producto.IdProducto;
        }

        public bool EliminarProducto(Producto producto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ArmarParametrosProductoEliminar(ref sqlCommand, producto);
            accesoDatos acceso = new accesoDatos();
            int FilasInsertadas = acceso.EjecutarProcedimientosAlmacenados(sqlCommand, "spEliminarProducto");
            if (FilasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    

    }
}