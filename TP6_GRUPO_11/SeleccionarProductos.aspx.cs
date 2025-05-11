using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_11.Conexion;

namespace TP6_GRUPO_11
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                CargarGridView();
            }
        }

        protected void GVProductosEj2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                string idProducto = e.CommandArgument.ToString();
                GridViewRow row = ((LinkButton)e.CommandSource).NamingContainer as GridViewRow;
                string nombreProducto = ((Label)row.FindControl("lbl_it_Nombre_Producto")).Text;
                string idProvedor = ((Label)row.FindControl("lbl_it_Id_Proveedor")).Text;
                string precioUnidad = ((Label)row.FindControl("lbl_it_Precio_Unitario")).Text;
                // ACÁ OBTENGO O CREO LA TABLA EN LA SESSION
                DataTable dataTable = Session["ProductosSeleccionados"] as DataTable;
                if (dataTable == null)
                {
                    dataTable = new DataTable();
                    dataTable.Columns.Add("IdProducto");
                    dataTable.Columns.Add("NombreProducto");
                    dataTable.Columns.Add("IdProveedor");
                    dataTable.Columns.Add("PrecioUnidad");
                    Session["ProductosSeleccionados"] = dataTable;
                }

                //ACÁ AGREGO EL PRODUCTO QUE SE SELECCIONÓ
                dataTable.Rows.Add(idProducto, nombreProducto,idProvedor,precioUnidad);

                //ACÁ ACTUALIZO EL LABEL CON LOS PRODUCTOS SELECCIONADOS
                lblSeleccionados.Text = $"Items seleccionados: {string.Join(", ", dataTable.AsEnumerable().Select(r => r["NombreProducto"].ToString()))}";
            }
        }



        private void CargarGridView()
        {
            gestionNeptuno gestionNeptunoEj2 = new gestionNeptuno();
            GVProductosEj2.DataSource = gestionNeptunoEj2.ObtenerProductos(); ///ACÁ OBTIENE LA TABLA
            GVProductosEj2.DataBind();

        }

        protected void GVProductosEj2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVProductosEj2.PageIndex = e.NewPageIndex;
            CargarGridView();
        }
    }

}