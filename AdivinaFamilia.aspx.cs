using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdivinaFamilia : System.Web.UI.Page
{
    List<csFoto> Fotos;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["IdRol"] != null && Session["IdUsuario"] != null)
        {
            int IdRol = Convert.ToInt32(Session["IdRol"]);

            if (IdRol == 1)
            {
                //Administrador
            }
            else if (IdRol == 2 || IdRol == 3)
            {
                int IdUsuario = Convert.ToInt32(Session["IdUsuario"]);
                bool exceptionServices = false;

                csInformacionUsuario InformacionUsuario = (new csInformacionUsuarioHandler()).Get(IdUsuario, out exceptionServices);

                if (!exceptionServices)
                {
                    Fotos = (new csFotoHandler()).GetList(InformacionUsuario.IdInformacionUsuario, out exceptionServices);
                    if (!exceptionServices)
                    {
                        int lengtFotos = Fotos.Count;

                        if (lengtFotos >= 3)
                        {
                            lblParentesco.Text = Fotos[0].Descripcion;

                            string base64String = Convert.ToBase64String(Fotos[0].Foto);
                            btnImageUno.ImageUrl = "data:image/jpeg;base64," + base64String;

                            base64String = Convert.ToBase64String(Fotos[1].Foto);
                            btnImageDos.ImageUrl = "data:image/jpeg;base64," + base64String;

                            base64String = Convert.ToBase64String(Fotos[2].Foto);
                            btnImageTres.ImageUrl = "data:image/jpeg;base64," + base64String;
                        }
                        else if(lengtFotos >= 2)
                        {
                            lblParentesco.Text = Fotos[0].Descripcion;
                            string base64String = Convert.ToBase64String(Fotos[0].Foto);
                            btnImageUno.ImageUrl = "data:image/jpeg;base64," + base64String;

                            base64String = Convert.ToBase64String(Fotos[1].Foto);
                            btnImageDos.ImageUrl = "data:image/jpeg;base64," + base64String;

                            btnImageTres.Visible = false;
                        }
                        else if(lengtFotos >= 1)
                        {
                            lblParentesco.Text = Fotos[0].Descripcion;
                            string base64String = Convert.ToBase64String(Fotos[0].Foto);
                            btnImageUno.ImageUrl = "data:image/jpeg;base64," + base64String;
                        }
                    }
                    else
                        Response.Write(@"<script language = 'javascript'>alert('Error en el servidor.') </script>");
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
}