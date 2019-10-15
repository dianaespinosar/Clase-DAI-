﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="usoControles.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Uso Controles<br />
            <br />
            Colores:<asp:DropDownList ID="ddColores" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddColores_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lbColores" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            Sabores:<br />
            <asp:RadioButtonList ID="rbSabores" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbSabores_SelectedIndexChanged" style="margin-top: 6px">
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="lbIndiceS" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbContenidoS" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:CheckBoxList ID="cbCafe" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbCafe_SelectedIndexChanged">
            </asp:CheckBoxList>
            <br />
            Índice:
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <br />
            <br />
            Contenido: <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="lbSession" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
