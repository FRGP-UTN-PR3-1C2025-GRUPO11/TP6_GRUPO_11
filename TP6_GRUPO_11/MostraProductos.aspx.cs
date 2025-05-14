using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_11
{
    public partial class MostraProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
            lblMostrarTotal.Text = "No hay productos seleccionados";
            if (Application["ProductosSeleccionados"]!=null)
            {
                gvProductos.DataSource = Application["ProductosSeleccionados"];
                gvProductos.DataBind();

                int contador = 0;

                foreach (GridViewRow fila in gvProductos.Rows)
                {
                    contador++;
                    
                }

                if (contador > 0)
                {
                    lblMostrarTotal.Text = "Total de productos seleccionados: " + contador.ToString();
                   
                }
                


            }



        }
    }
}