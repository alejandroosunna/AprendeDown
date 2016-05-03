using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Boolean exceptionServices = false;

        if (Request["Re"] != null)
        {
            if(Request["Re"] == "ex")
                Response.Write(@"<script language = 'javascript'>alert('Se Registro con exito.') </script>");
        }

        if (Session["IdUsuario"] != null)
        {
            csUsuario Usuario = (new csUsuarioHandler()).Get(Convert.ToInt32(Session["IdUsuario"]), out exceptionServices);

            if (!exceptionServices)
            {
                if (Usuario.IdRol == 1)
                {
                    //Administrador
                }
                else if (Usuario.IdRol == 2 || Usuario.IdRol == 3)
                    Response.Redirect("~\\Index.aspx");
            }
            else
                Response.Write(@"<script language = 'javascript'>alert('Error en el servidor.') </script>");
        }
    }

    protected void btnIniciar_Click(object sender, EventArgs e)
    {
        bool exceptionServices = false;
        csUsuario Usuario = (new csUsuarioHandler()).Get(txtUsername.Text, txtPasswrd.Text, out exceptionServices);

        if (!exceptionServices)
        {
            if (Usuario.IdRol == 1)
            {
                //Administrador
            }
            else if (Usuario.IdRol == 2)
            {
                Session["IdRol"] = Usuario.IdRol;
                Session["IdUsuario"] = Usuario.IdUsuario;
                Response.Redirect("~\\Index.aspx");
            }
            else if (Usuario.IdRol == 3)
            {
                Session["IdRol"] = Usuario.IdRol;
                Session["IdUsuario"] = Usuario.IdUsuario;
                Response.Redirect("~\\Index.aspx");
            }
            else if(Usuario.IdRol == 0)
                Response.Write(@"<script language = 'javascript'>alert('Credenciales Incorrectas.') </script>");
        }
        else
            Response.Write(@"<script language = 'javascript'>alert('Error en el servidor.') </script>");
    }
}