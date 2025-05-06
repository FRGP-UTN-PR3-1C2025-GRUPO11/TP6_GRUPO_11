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
            DataTable tabla = ObtenerTabla("Productos", "SELECT * FROM Productos");
            tabla.Columns["IdProducto"].ColumnName = "ID Producto";
            tabla.Columns["NombreProducto"].ColumnName = "Nombre Producto";
            tabla.Columns["IdProveedor"].ColumnName = "Id Proveedor";
            tabla.Columns["IdCategoría"].ColumnName = "Id Categoría";
            tabla.Columns["CantidadPorUnidad"].ColumnName = "Cantidad Por Unidad";
            tabla.Columns["PrecioUnidad"].ColumnName = "Precio Unidad";
            tabla.Columns["UnidadesEnExistencia"].ColumnName = "Unidades en Existencia";
            tabla.Columns["UnidadesEnPedido"].ColumnName = "Unidades en Pedido";
            tabla.Columns["NivelNuevoPedido"].ColumnName = "Nivel nuevo Pedido";

            return tabla;
        }
    }
}