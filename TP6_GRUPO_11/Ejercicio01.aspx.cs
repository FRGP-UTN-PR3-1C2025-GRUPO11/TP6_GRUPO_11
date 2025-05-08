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

           Productos productos = new Productos(Convert.ToInt32(idProducto));
           gestionNeptuno gestion = new gestionNeptuno();
            
           gestion.EliminarProducto(productos);
           CargarGridView();

        }
    }
}