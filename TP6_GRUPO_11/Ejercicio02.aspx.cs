﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_11
{
    public partial class Ejercicio02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EliminarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            try
            {
                Application["ProductosSeleccionados"] = null;
                lblEliminados.Text = "Productos eliminados de la lista de seleccionados";

            }
            catch (Exception exception)
            {
                lblEliminados.Text = "Error desconocido";
            }
        }
    }
}