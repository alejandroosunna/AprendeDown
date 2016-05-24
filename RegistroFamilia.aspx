<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistroFamilia.aspx.cs" Inherits="RegistroFamilia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="materialize/css/materialize.css" />
    <link rel="stylesheet" type="text/javascript" href="materialize/js/materialize.js" />
    <link rel="stylesheet" type="text/javascript" href="materialize/jquery-2.2.3.js" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
</head>
<body>
    <form id="frmRegistroFamilia" runat="server">
    <div class="container">
        <div class="row"><h4>Parentesco:</h4></div>
            <div class="row center">                
                <div class="col s12 m12 l4">
                    <label>Selecciona Parentesco</label>
                    <div class="input-field col">
                    <select id="parentescoDrop" class="browser-default" runat="server">
                    </select>                    
                    </div>
                </div>
                <div class="col s12 m12 l8">
                    <div class="input-field">
                        <asp:TextBox ID="txtNombreCompleto" runat="server"></asp:TextBox>
                        <label>Nombre completo: </label>
                    </div>
                </div>
            </div>
        <div class="row">
            <div class="col s12 m12 l6 center">
                <div class="row center"><h6>Imagen:</h6></div>
                <div class="row center"><asp:FileUpload ID="fileUpload" runat="server"/></div>
            </div>
            <div class="col s12 m12 l6">
                <div class="row center">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
                </div>
                <div class="row center">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
                </div>
            </div>
        </div>
        
        <br />
        <br />
    </div>
        <script type="text/javascript" src="materialize/jquery-2.2.3.js"></script>
            <script type="text/javascript" src="materialize/js/materialize.js"></script>
            <script type="text/javascript" lang="javascript">
                $(document).ready(function () {
                    $('.button-collapse').sideNav();
                });
           </script>
    </form>
</body>
</html>
