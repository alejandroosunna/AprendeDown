<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="Registro" %>

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
<body class="white">
    <form id="frmRegistro" class="row" runat="server">
        <header>
            <div class="navbar-fixed">
                <nav>
                <div class="nav-wrapper blue darken-3 white-text">
                    <a href="Login.aspx" class="brand-logo">Aprende Down</a>
                    <a href="#" data-activates="slide-out" class="button-collapse"><i class="mdi-navigation-menu material-icons">menu</i></a>
                    <ul class="right hide-on-med-and-down">
                        <li><a href="AdivinaAnimales.aspx">Animales</a></li>
                        <li><a href="AdivinaCuerpoHumano.aspx">Cuerpo Humano</a></li>
                        <li><a href="AdivinaFamilia.aspx">Familia</a></li>
                        <li><a href="Login.aspx">Login</a></li>
                        <li><a href="Registro.aspx">Registro</a></li>
                        <li><a href="RegistroFamilia.aspx">Registro Familia</a></li>
                    </ul>
                    <ul id="slide-out" class="side-nav">
                        <li><a href="AdivinaAnimales.aspx">Animales</a></li>
                        <li><a href="AdivinaCuerpoHumano.aspx">Cuerpo Humano</a></li>
                        <li><a href="AdivinaFamilia.aspx">Familia</a></li>
                        <li><a href="Login.aspx">Login</a></li>
                        <li><a href="Registro.aspx">Registro</a></li>
                        <li><a href="RegistroFamilia.aspx">Registro Familia</a></li>
                    </ul>
                </div>
            </nav>
            </div>
        </header>
        <main class="container">
            <br />
            <h2 class="center-align">Registrarse</h2>
             <div class="col s12 m12 l6 offset-l3">
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
        <div class="row center-align">
            Foto: <%--<asp:TextBox ID="txtNombreFoto" runat="server" Enabled="false"></asp:TextBox> --%> <asp:FileUpload ID="fileUpload"  CssClass="file-field" runat="server"/> <%--<asp:Button ID="btnBuscar" runat="server" Text="Buscar..." OnClick="btnBuscar_Click"/>--%>
        <br />
        </div>
        <div class="row center-align">
            <asp:Button ID="btnRegistrarse" CssClass="btn blue darken-2 white-text" runat="server" Text="Registrarse" OnClick="btnRegistrarse_Click"/>
        </div>        
    </div>
        </main>
    
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
