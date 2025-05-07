using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_11.Conexion
{
    public class Productos
    {
        private int _IdProducto;
        private string _NombreProducto;
        private string _CantidadPorUnidad;
        private decimal _PrecioUnidad;
        public Productos()
        {

        }

        public Productos(int idProducto,string nombreProducto,string cantidadPorUnidad,decimal precioUnidad) {
            _IdProducto = idProducto;
            _NombreProducto = nombreProducto;
            _CantidadPorUnidad = cantidadPorUnidad;
            _PrecioUnidad = precioUnidad;
        }

        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }

        public string NombreProducto { 
            get { return _NombreProducto; }
            set { _NombreProducto= value; }
        }

        public string CantidadPorUnidad
        {
            get { return _CantidadPorUnidad; }
            set { _CantidadPorUnidad= value; }
        }
        public decimal PrecioUnidad
        {
            get { return _PrecioUnidad; }
            set { _PrecioUnidad= value; }
        }



    }
}
