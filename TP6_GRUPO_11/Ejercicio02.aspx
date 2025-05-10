<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio02.aspx.cs" Inherits="TP6_GRUPO_11.Ejercicio02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="formularioEj02" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Inicio"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HPSeleccionarProductos" runat="server" Font-Underline="True" ForeColor="#3333FF" NavigateUrl="~/SeleccionarProductos.aspx">Seleccionar Productos</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
