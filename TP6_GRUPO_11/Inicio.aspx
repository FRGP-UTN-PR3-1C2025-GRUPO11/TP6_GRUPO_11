<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_GRUPO_11.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>hola</title>
    <style>
        div {
            display: flex;
            flex-direction: column;
            gap: 60px;
        }
    </style>
</head>
<body>
    <form id="formularioInicio" runat="server">
        <div>
        GRUPO N°11
        <asp:HyperLink runat="server" NavigateUrl="~/Ejercicio01.aspx" Text="Ejercicio 1"></asp:HyperLink>
        <asp:HyperLink runat="server" NavigateUrl="~/Ejercicio02.aspx" Text="Ejercicio 2"></asp:HyperLink>
        </div>

    </form>
</body>
</html>
