<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdivinaFamilia.aspx.cs" Inherits="AdivinaFamilia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="frmAdivinaFamilia" runat="server">
    <div>
        <asp:Label ID="lblParentesco" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:ImageButton ID="btnImageUno" runat="server" Width="100px" Height="100px"/>
        <asp:ImageButton ID="btnImageDos" runat="server" Width="100px" Height="100px"/>
        <asp:ImageButton ID="btnImageTres" runat="server" Width="100px" Height="100px"/>
    </div>
    </form>
</body>
</html>
