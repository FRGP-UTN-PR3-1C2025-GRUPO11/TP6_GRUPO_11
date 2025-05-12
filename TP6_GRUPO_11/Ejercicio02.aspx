<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio02.aspx.cs" Inherits="TP6_GRUPO_11.Ejercicio02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>TP 6 - GRUPO 11 - Ejercicio 2</title>
    <link rel="stylesheet" href="~/css/style.css" type="text/css" />
    <style>
        .botones a, 
        .botones input[type="submit"] {
            color: white;
            font-size: 14px;
            text-decoration: none;
            margin: 4px 2px;
            cursor: pointer;
            width: 320px;
            text-align: center;
            padding: 10px 20px;
            font-weight: bolder;
            font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; 
            display: inline-block;
            border: none;
            box-sizing: border-box;
            border-radius: 4px;
        }
        #EliminarProductosSeleccionados 
        {
            background-color: #FF0000;
        }
        #HPSeleccionarProductos 
        {
            background-color: #00FF00;
        }

        #HlMostrarProductos
        {
            background-color: #0000FF;
        }

    </style>
</head>
<body>
    <div class="content">
                <h1>Inicio</h1>
        <form id="formularioEj02" runat="server">
            <div class="botones">
                <asp:HyperLink ID="HPSeleccionarProductos" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Seleccionar Productos</asp:HyperLink>
                <div style="flex-direction: row">
                    <asp:Button ID="EliminarProductosSeleccionados" runat="server" Text="Eliminar Productos Seleccionados" OnClick="EliminarProductosSeleccionados_Click" />
                    <asp:Label ID="lblEliminados" runat="server" style="line-height:35px; color: red; font-weight: bolder "></asp:Label>
                </div>
                <asp:HyperLink ID="HlMostrarProductos" runat="server" NavigateUrl="~/MostraProductos.aspx">Mostrar Productos</asp:HyperLink>
            </div>
        </form>
        <asp:HyperLink ID="hlEjercicios" runat="server" NavigateUrl="~/Inicio.aspx" Text="Volver a Ejercicios" ForeColor="Black">Volver a Ejercicios</asp:HyperLink>
    </div>
</body>
</html>
