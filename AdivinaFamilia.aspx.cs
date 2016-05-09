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
        if (!IsPostBack)
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
                    if (Request["Error"] != null)
                    {
                        if (Request["Error"] == "err")
                            Response.Write(@"<script language = 'javascript'>alert('Error en el servidor.') </script>");
                    }
                    if (Request["Adivina"] != null)
                    {
                        if(Request["Adivina"] == "ex")
                            Response.Write(@"<script language = 'javascript'>alert('Si, el es :)') </script>");
                        else if(Request["Adivina"] == "err")
                            Response.Write(@"<script language = 'javascript'>alert('No, el no es :(') </script>");
                    }

                    int IdUsuario = Convert.ToInt32(Session["IdUsuario"]);
                    bool exceptionServices = false;

                    csInformacionUsuario InformacionUsuario = (new csInformacionUsuarioHandler()).Get(IdUsuario, out exceptionServices);

                    if (!exceptionServices)
                    {
                        Fotos = (new csFotoHandler()).GetList(InformacionUsuario.IdInformacionUsuario, out exceptionServices);
                        if (!exceptionServices)
                        {
                            Random random = new Random();
                            int lengtFotos = Fotos.Count;
                            int posUno = 0;
                            int posDos = 0;
                            int posRandom = random.Next(lengtFotos);

                            if (lengtFotos >= 3)
                            {
                                if (posRandom == 0) { posUno = 1; posDos = 2; }
                                else if (posRandom == 1) { posUno = 0; posDos = 2; }
                                else if (posRandom == 2) { posUno = 0; posDos = 1; }

                                lblIdFotoUno.Text = Fotos[posRandom].IdFoto.ToString();
                                lblIdFotoDos.Text = Fotos[posUno].IdFoto.ToString();
                                lblIdFotoTres.Text = Fotos[posDos].IdFoto.ToString();
                                lblParentesco.Text = Fotos[posRandom].Descripcion;

                                string base64String = Convert.ToBase64String(Fotos[posRandom].Foto);
                                btnImageUno.ImageUrl = "data:image/jpeg;base64," + base64String;

                                base64String = Convert.ToBase64String(Fotos[posUno].Foto);
                                btnImageDos.ImageUrl = "data:image/jpeg;base64," + base64String;

                                base64String = Convert.ToBase64String(Fotos[posDos].Foto);
                                btnImageTres.ImageUrl = "data:image/jpeg;base64," + base64String;
                            }
                            else if (lengtFotos >= 2)
                            {
                                if (posRandom == 0) { posUno = 1; }
                                else if (posRandom == 1) { posUno = 0; }

                                lblIdFotoUno.Text = Fotos[posRandom].IdFoto.ToString();
                                lblIdFotoTres.Text = Fotos[posUno].IdFoto.ToString();
                                lblParentesco.Text = Fotos[posRandom].Descripcion;

                                string base64String = Convert.ToBase64String(Fotos[posRandom].Foto);
                                btnImageUno.ImageUrl = "data:image/jpeg;base64," + base64String;

                                base64String = Convert.ToBase64String(Fotos[posUno].Foto);
                                btnImageTres.ImageUrl = "data:image/jpeg;base64," + base64String;

                                btnImageDos.Visible = false;
                            }
                            else if (lengtFotos >= 1)
                            {
                                lblIdFotoDos.Text = Fotos[posRandom].IdFoto.ToString();
                                lblParentesco.Text = Fotos[posRandom].Descripcion;

                                string base64String = Convert.ToBase64String(Fotos[posRandom].Foto);
                                btnImageDos.ImageUrl = "data:image/jpeg;base64," + base64String;

                                btnImageUno.Visible = false;
                                btnImageTres.Visible = false;
                            }
                        }
                        else
                            Response.Redirect("~\\AdivinaFamilia.aspx?Error=err");
                    }
                    else
                        Response.Redirect("~\\AdivinaFamilia.aspx?Error=err");
                }
                else
                    Response.Redirect("~\\Login.aspx");
            }
            else
                Response.Redirect("~\\Login.aspx");
        }
    }

    protected void btnImage_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton btnImage = (ImageButton)sender;
        Boolean exceptionServices = false;

        if (btnImage.ID == "btnImageUno")
        {
            csFoto Foto = (new csFotoHandler()).Get(Convert.ToInt32(lblIdFotoUno.Text), out exceptionServices);

            if (!exceptionServices)
            {
                if(Foto.Descripcion == lblParentesco.Text)
                    Response.Redirect("~\\AdivinaFamilia.aspx?Adivina=ex");
                else
                    Response.Redirect("~\\AdivinaFamilia.aspx?Adivina=err");
            }
            else
                Response.Redirect("~\\AdivinaFamilia.aspx?Error=err");
        }
        else if(btnImage.ID == "btnImageDos")
        {
            csFoto Foto = (new csFotoHandler()).Get(Convert.ToInt32(lblIdFotoDos.Text), out exceptionServices);

            if (!exceptionServices)
            {
                if (Foto.Descripcion == lblParentesco.Text)
                    Response.Redirect("~\\AdivinaFamilia.aspx?Adivina=ex");
                else
                    Response.Redirect("~\\AdivinaFamilia.aspx?Adivina=err");
            }
            else
                Response.Redirect("~\\AdivinaFamilia.aspx?Error=err");
        }
        else if(btnImage.ID == "btnImageTres")
        {
            csFoto Foto = (new csFotoHandler()).Get(Convert.ToInt32(lblIdFotoTres.Text), out exceptionServices);

            if (!exceptionServices)
            {
                if (Foto.Descripcion == lblParentesco.Text)
                    Response.Redirect("~\\AdivinaFamilia.aspx?Adivina=ex");
                else
                    Response.Redirect("~\\AdivinaFamilia.aspx?Adivina=err");
            }
            else
                Response.Redirect("~\\AdivinaFamilia.aspx?Error=err");
        }
    }
}