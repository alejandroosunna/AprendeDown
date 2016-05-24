<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="materialize/css/materialize.css" media="screen,projection" />
    <link rel="stylesheet" type="text/javascript" href="materialize/js/materialize.js" />
    <link rel="stylesheet" type="text/javascript" href="materialize/jquery-2.2.3.js" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
</head>
<body>
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
    <form id="formLogin" runat="server">
    <div class="row">
        <div class="col s12 m12 l6 offset-l3">
            <div class="card blue darken-2 z-depth-2">
                <div class="card-content">
                    <div class="row center-align white-text">
                        <i class="material-icons large">account_circle</i>
                    </div>
                    <div class="row center-align white-text">
                        Nombre de Usuario: <asp:TextBox ID="txtUsername" CssClass="white-text" runat="server"></asp:TextBox>
                    </div><br />
                    <div class="row center-align white-text">
                        Contraseña: <asp:TextBox ID="txtPasswrd" CssClass="white-text" type="password" runat="server"></asp:TextBox>
                    </div>
                    <div class="row center-align white-text">
                        <asp:Button ID="btnIniciar" CssClass="btn white black-text z-depth-2" runat="server" Text="Iniciar Sesión" OnClick="btnIniciar_Click"/>
                    </div><br />
                    <%--<asp:LinkButton ID="linkRegistrar" runat="server" Text="Registrarse"></asp:LinkButton>--%>
                    <div class="card-action center-align">
                        <a href="Registro.aspx" class="white-text">Registrarse</a><br />
                    </div>
                </div>
            </div>
        </div>
    </div>        
    </form>
    <script type="text/javascript" src="materialize/jquery-2.2.3.js"></script>
            <script type="text/javascript" src="materialize/js/materialize.js"></script>
            <script type="text/javascript" lang="javascript">
                $(document).ready(function () {
                    $('.button-collapse').sideNav();
                });
           </script>
</body>
</html>
