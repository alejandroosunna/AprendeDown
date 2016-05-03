using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["IdRol"] != null && Session["IdUsuario"] != null)
        {
            int IdRol = Convert.ToInt32(Session["IdRol"]);

            if (IdRol == 1)
            {
                //Administrador
            }
            else if(IdRol == 2 || IdRol == 3)
            {
                int IdUsuario = Convert.ToInt32(Session["IdUsuario"]);
                bool exceptionServices = false;

                csInformacionUsuario InformacionUsuario = (new csInformacionUsuarioHandler()).Get(IdUsuario, out exceptionServices);

                if(!exceptionServices)
                {
                    lblNombre.Text = InformacionUsuario.Nombre + " " + InformacionUsuario.ApellidoPaterno + " " + InformacionUsuario.ApellidoMaterno;
                    string base64String = Convert.ToBase64String(InformacionUsuario.Foto);
                    imagePerfil.ImageUrl = "data:image/jpeg;base64," + base64String;
                }
                else
                    Response.Write(@"<script language = 'javascript'>alert('Error en el servidor.') </script>");
            }
            else
                Response.Redirect("~\\Login.aspx");
        }
        else
            Response.Redirect("~\\Login.aspx");
    }

    protected void linkCerrarSecion_Click(object sender, EventArgs e)
    {
        Session["IdRol"] = null;
        Session["IdUsuario"] = null;
        Response.Redirect("~\\Login.aspx");
    }
}