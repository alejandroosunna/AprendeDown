<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="frmRegistro" runat="server">
    <div>
        Nombre: <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        Apellido Paterno: <asp:TextBox ID="txtApellidoPaterno" runat="server"></asp:TextBox>
        <br />
        Apellido Materno: <asp:TextBox ID="txtApellidoMaterno" runat="server"></asp:TextBox>
        <br />
        Edad: <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <br />
        Fecha de nacimiento: <input id="date-range-predefined" name="Fecha" type="date" class="datepicker h5a-input form-control"/>
        <br />
        Lugar Origen: <asp:TextBox ID="txtOrigen" runat="server"></asp:TextBox>
        <br />
        Nombre de Usuario: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        Contraseña: <asp:TextBox ID="txtPasswrd" runat="server"></asp:TextBox>
        <br />
        Foto: <%--<asp:TextBox ID="txtNombreFoto" runat="server" Enabled="false"></asp:TextBox> --%> <asp:FileUpload ID="fileUpload" runat="server"/> <%--<asp:Button ID="btnBuscar" runat="server" Text="Buscar..." OnClick="btnBuscar_Click"/>--%>
        <br />
        <asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" OnClick="btnRegistrarse_Click"/>
    </div>
    </form>
</body>
</html>
