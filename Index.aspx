<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="frmIndex" runat="server">
    <div>
        Bienvenido: <asp:Label ID="lblNombre" runat="server"></asp:Label>
        <asp:Image ID="imagePerfil" runat="server" Width="80px" Height="80px"/>
        <br />
        <br />
        <br />
        <asp:LinkButton ID="linkCerrarSecion" runat="server" Text="Cerrar Secion" OnClick="linkCerrarSecion_Click"></asp:LinkButton>
    </div>
    </form>
</body>
</html>
