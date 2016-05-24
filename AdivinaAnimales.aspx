<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdivinaAnimales.aspx.cs" Inherits="AdivinaAnimales" %>

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
<body style="background-image:url(Imagenes/Images/animales.svg);">
     <div class="row">
        <div class="header center"><asp:Label ID="lblParentesco" runat="server"></asp:Label></div>
        <div class="col s12 m12 l4">
            <div class="card blue darken-3 white-text">
                <div class="card-image">
                    <asp:ImageButton ID="btnImageUno" runat="server" CssClass="responsive-image" OnClick="btnImage_Click"/>
                </div>
                <div class="card-content"><asp:Label ID="lblIdFotoUno" CssClass="card-title white-text" runat="server" Visible="false"></asp:Label></div>
            </div>
        </div>
        <div class="col s12 m12 l4">
            <div class="card green darken-3 white-text">
                <div class="card-image">
                    <asp:ImageButton ID="btnImageDos" runat="server" CssClass="responsive-image" OnClick="btnImage_Click"/>
                </div>
                <div class="card=content"><asp:Label ID="lblIdFotoDos" CssClass="card-title white-text" runat="server" Visible="false"></asp:Label></div>
            </div>
        </div>
        <div class="col s12 m12 l4">
            <div class="card orange darken-3 white-text">
                <div class="card-image">
                    <asp:ImageButton ID="btnImageTres" runat="server" CssClass="responsive-image" OnClick="btnImage_Click"/>
                </div>
                <div class="card-content"><asp:Label ID="lblIdFotoTres" CssClass="card-title white-text" runat="server" Visible="false"></asp:Label></div>
            </div>
        </div>
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
