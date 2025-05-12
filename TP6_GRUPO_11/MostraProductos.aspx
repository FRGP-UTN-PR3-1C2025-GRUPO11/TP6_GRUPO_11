<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostraProductos.aspx.cs" Inherits="TP6_GRUPO_11.MostraProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>TP 6 - GRUPO 11 - Ejercicio 2 - Mostrar Productos</title>
    <link rel="stylesheet" href="~/css/style.css" type="text/css" />
</head>
<body>
    <div class="content">
    <h1>Productos Seleccionados</h1>
    <form id="formularioMostraProductos" runat="server">
        <div>
            <asp:GridView ID="gvProductos" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <asp:HyperLink ID="hlInicio" runat="server" NavigateUrl="~/Ejercicio02.aspx">Ir al inicio</asp:HyperLink>
        </div>

    </form>
    </div>
</body>
</html>
