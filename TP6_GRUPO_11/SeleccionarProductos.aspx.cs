using System;
using System.Collections.Generic;
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



        private void CargarGridView()
        {
            gestionNeptuno gestionNeptunoEj2 = new gestionNeptuno();
            GVProductosEj2.DataSource = gestionNeptunoEj2.ObtenerProductos(); ///ACÁ OBTIENE LA TABLA
            GVProductosEj2.DataBind();

        }



    }

}