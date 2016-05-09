<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdivinaAnimales.aspx.cs" Inherits="AdivinaAnimales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="frmAdivinaAnimales" runat="server">
    <div>
        <asp:Label ID="lblParentesco" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:ImageButton ID="btnImageUno" runat="server" Width="100px" Height="100px" OnClick="btnImage_Click"/>
        <asp:ImageButton ID="btnImageDos" runat="server" Width="100px" Height="100px" OnClick="btnImage_Click"/>
        <asp:ImageButton ID="btnImageTres" runat="server" Width="100px" Height="100px" OnClick="btnImage_Click"/>
        <asp:Label ID="lblIdFotoUno" runat="server" Visible="false"></asp:Label>
        <asp:Label ID="lblIdFotoDos" runat="server" Visible="false"></asp:Label>
        <asp:Label ID="lblIdFotoTres" runat="server" Visible="false"></asp:Label>
    </div>
    </form>
</body>
</html>
