<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistroFamilia.aspx.cs" Inherits="RegistroFamilia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="frmRegistroFamilia" runat="server">
    <div>
        Parentesco:
            <div class="row container">
                <div class="input-field col s12">
                    <select id="parentescoDrop" runat="server">
                    </select>
                    <label>Selecciona Parentesco</label>
                    </div>
            </div>
        <br />
        <br />
        Nombre completo: <asp:TextBox ID="txtNombreCompleto" runat="server"></asp:TextBox>
        <br />
        <asp:FileUpload ID="fileUpload" runat="server"/>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>  <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
    </div>
    </form>
</body>
</html>
