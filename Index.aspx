<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

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
<body style="background-image:url(Imagenes/Images/index.svg);">
    <form id="frmIndex" runat="server">
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
            <main>
                <div class="row container">
                    <div class="col s12 m12 l6 offset-l3">
                        <div class="card cyan darken-2">
                            <div class="card-image">
                                <asp:Image ID="imagePerfil" runat="server" CssClass="responsive-image"/>
                            </div>
                            <span class="card-title center-align white-text">Bienvenido:</span>
                            <div class="card-content center-align">
                                <asp:Label ID="lblNombre" CssClass="white-text" runat="server"></asp:Label>
                            </div>
                            <div class="card-action center-align">
                                <asp:LinkButton ID="linkCerrarSecion" CssClass="white-text" runat="server" Text="Cerrar Sesion" OnClick="linkCerrarSecion_Click"></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row container">
                    <div class="col s12 m12 l6 center">
                        <a href="AdivinaAnimales.aspx" class="btn-floating btn-large circle blue darken-2 white-text large z-depth-5" style="height:200px;width:200px;"><br /><h5 class="valign">Familia</h5><i class="material-icons">supervisor_account</i></a>
                    </div>
                    <div class="col s12 m12 l6 center">
                        <a href="AdivinaCuerpoHumano.aspx" class="btn-floating btn-large circle orange darken-2 white-text large z-depth-5" style="height:200px;width:200px;"><br /><h5 class="valign">Cuerpo</h5><i class="material-icons">directions_walk</i></a>
                    </div>
                </div>
                <div class="row container">
                    <div class="col s12 m12 l6 center">
                            <a href="AdivinaAnimales.aspx" class="btn-floating btn-large circle green darken-2 white-text large z-depth-5" style="height:200px;width:200px;"><br /><h5>Animales</h5><i class="material-icons">pets</i></a>
                    </div>
                    <div class="col s12 m12 l6 center">
                            <a href="RegistroFamilia.aspx" class="btn-floating btn-large circle blue-grey darken-2 white-text large z-depth-5" style="height:200px;width:200px;"><br /><h5>Registro Familia</h5><i class="material-icons" style="vertical-align:middle;">mode_edit</i></a>
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
