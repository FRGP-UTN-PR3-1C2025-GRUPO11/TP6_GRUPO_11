using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_11.Conexion;
using static System.Collections.Specialized.BitVector32;

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
            gvProductos.PageIndex = e.NewPageIndex;
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



        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {


        }

        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            CargarGridView();
        }

        protected void gvProductos_RowUpdating1(System.Object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            // Accede al control dentro del EditItemTemplate
            string idProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_idProducto")).Text;
            string nombreProducto = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_nombreProducto")).Text;
            string cantidadPorUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("TextBox1")).Text;
            string precioUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_PrecioUnidad")).Text;

            // Crear el objeto Producto y asignar los valores
            Producto producto = new Producto(Convert.ToInt32(idProducto), nombreProducto, cantidadPorUnidad, Convert.ToDecimal(precioUnidad));

            // Me conecto a la base
            gestionNeptuno gestion = new gestionNeptuno();

            // ACTUALIZO
            gestion.ActualizarProducto(producto);

            // Salir del modo de edición
            gvProductos.EditIndex = -1;

            // Recargar el GridView
            CargarGridView();
        }

        protected void gvProductos_RowCancelingEdit(System.Object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1;
            CargarGridView();
        }

        protected void btnBuscarProd_Click(object sender, EventArgs e)
        {
            gestionNeptuno gestion = new gestionNeptuno();

            DataTable productos = gestion.ObtenerProductos();

            string idProducto = txtBuscarProducto.Text;

            string productoEncontrado="";



            foreach (DataRow fila in productos.Rows)
            {
                
                if (Convert.ToInt32(fila["IdProducto"])== Convert.ToInt32(idProducto))
                {
                    productoEncontrado = "Nombre: " + fila["NombreProducto"].ToString() + "<br>" +
                                  "Cantidad por unidad: " + fila["CantidadPorUnidad"].ToString() + "<br>" +
                                  "Precio: " + fila["PrecioUnidad"].ToString();
                }
                else
                {
                    txtBuscarProducto.Text = "";
                }
             
            }
            lblBuscarP.Text = productoEncontrado;

            

        }
    }
}


