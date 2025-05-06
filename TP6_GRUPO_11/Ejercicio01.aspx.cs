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
            gestionNeptuno gestionNeptuno = new gestionNeptuno();
            gvProductos.DataSource = gestionNeptuno.ObtenerProductos(); ///ACÁ OBTIENE LA TABLA
            gvProductos.DataBind();
        }
    }
}