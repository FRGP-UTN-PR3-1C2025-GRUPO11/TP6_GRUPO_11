using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_11.Conexion;

namespace TP6_GRUPO_11
{
    public partial class Ejercicio01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                CargarGridView();
            }
        }

        private void CargarGridView()
        {
            gestionNeptuno gestionNeptuno = new gestionNeptuno();
            gvProductos.DataSource = gestionNeptuno.ObtenerProductos(); ///ACÁ OBTIENE LA TABLA
            gvProductos.DataBind();

        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex= e.NewPageIndex;
            CargarGridView();

        }

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lblIdProducto")).Text;

           Producto producto = new Producto(Convert.ToInt32(idProducto));
           gestionNeptuno gestion = new gestionNeptuno();
            
           gestion.EliminarProducto(producto);
           CargarGridView();

        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            // Accede al control dentro del EditItemTemplate
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_idProducto")).Text;
            string nombreProducto = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("tb_eit_nombreProducto")).Text;
            string cantidadPorUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("tb_eit_cantidadPorUnidad")).Text;
            string precioUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("tb_eit_precioUnidad")).Text;

            // Crear el objeto Producto y asignar los valores
            Producto producto = new Producto();
            producto.IdProducto = Convert.ToInt32(idProducto);
            producto.NombreProducto = nombreProducto;
            producto.CantidadPorUnidad = cantidadPorUnidad;
            producto.PrecioUnidad = Convert.ToDecimal(precioUnidad);

            // Me conecto a la base
            gestionNeptuno gestion = new gestionNeptuno();

            // ACTUALIZO
            // TODO: gestion.actualizarProducto(producto);

            // Salir del modo de edición
            gvProductos.EditIndex = -1;

            // Recargar el GridView
            CargarGridView();
        }
    }
}