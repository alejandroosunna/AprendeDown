<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="formLogin" runat="server">
    <div>
        Nombre de Usuario: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        <br />
        Contraseña: <asp:TextBox ID="txtPasswrd" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnIniciar" runat="server" Text="Iniciar Seción" OnClick="btnIniciar_Click"/>
        <br />
        <br />
        <%--<asp:LinkButton ID="linkRegistrar" runat="server" Text="Registrarse"></asp:LinkButton>--%>
        <a href="Registro.aspx">Registrarse</a>
    </div>
    </form>
</body>
</html>
