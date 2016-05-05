using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdivinaAnimales : System.Web.UI.Page
{
    List<csImagen> Imagenes;
    int IdJuegoAdivina = 2;
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
                        if (Request["Adivina"] == "ex")
                            Response.Write(@"<script language = 'javascript'>alert('Si, el es :)') </script>");
                        else if (Request["Adivina"] == "err")
                            Response.Write(@"<script language = 'javascript'>alert('No, el no es :(') </script>");
                    }

                    Boolean exceptionServices = false;

                    Imagenes = (new csImagenHandler()).GetList(IdJuegoAdivina, out exceptionServices);

                    if (!exceptionServices)
                    {
                        Random random = new Random();
                        bool boolRandom = true;
                        int lengtFotos = Imagenes.Count;
                        int posUno = 0;
                        int posDos = 0;
                        int posRandom = random.Next(lengtFotos);
                        int posButton = random.Next(3);

                        if (lengtFotos >= 3)
                        {
                            while (boolRandom)
                            {
                                posUno = random.Next(lengtFotos);

                                if (posUno != posRandom)
                                    boolRandom = false;
                            }

                            while (!boolRandom)
                            {
                                posDos = random.Next(lengtFotos);

                                if (posDos != posRandom && posDos != posUno)
                                    boolRandom = true;
                            }

                            lblParentesco.Text = Imagenes[posRandom].Descripcion;

                            if (posButton == 0)
                            {
                                lblIdFotoUno.Text = Imagenes[posRandom].IdImagen.ToString();
                                lblIdFotoDos.Text = Imagenes[posUno].IdImagen.ToString();
                                lblIdFotoTres.Text = Imagenes[posDos].IdImagen.ToString();

                                btnImageUno.ImageUrl = Imagenes[posRandom].Imagen;
                                btnImageDos.ImageUrl = Imagenes[posUno].Imagen;
                                btnImageTres.ImageUrl = Imagenes[posDos].Imagen;
                            }
                            else if (posButton == 1)
                            {
                                lblIdFotoUno.Text = Imagenes[posUno].IdImagen.ToString();
                                lblIdFotoDos.Text = Imagenes[posRandom].IdImagen.ToString();
                                lblIdFotoTres.Text = Imagenes[posDos].IdImagen.ToString();

                                btnImageUno.ImageUrl = Imagenes[posUno].Imagen;
                                btnImageDos.ImageUrl = Imagenes[posRandom].Imagen;
                                btnImageTres.ImageUrl = Imagenes[posDos].Imagen;
                            }
                            else if (posButton == 2)
                            {
                                lblIdFotoUno.Text = Imagenes[posUno].IdImagen.ToString();
                                lblIdFotoDos.Text = Imagenes[posDos].IdImagen.ToString();
                                lblIdFotoTres.Text = Imagenes[posRandom].IdImagen.ToString();

                                btnImageUno.ImageUrl = Imagenes[posUno].Imagen;
                                btnImageDos.ImageUrl = Imagenes[posDos].Imagen;
                                btnImageTres.ImageUrl = Imagenes[posRandom].Imagen;
                            }
                        }
                        else if (lengtFotos >= 2)
                        {
                            if (posRandom == 0) { posUno = 1; }
                            else if (posRandom == 1) { posUno = 0; }

                            lblIdFotoUno.Text = Imagenes[posRandom].IdImagen.ToString();
                            lblIdFotoTres.Text = Imagenes[posUno].IdImagen.ToString();
                            lblParentesco.Text = Imagenes[posRandom].Descripcion;

                            //string base64String = Convert.ToBase64String(Imagenes[posRandom].Imagen);
                            btnImageUno.ImageUrl = Imagenes[posRandom].Imagen;

                            //base64String = Convert.ToBase64String(Imagenes[posUno].Imagen);
                            btnImageTres.ImageUrl = Imagenes[posUno].Imagen;

                            btnImageDos.Visible = false;
                        }
                        else if (lengtFotos >= 1)
                        {
                            lblIdFotoDos.Text = Imagenes[posRandom].IdImagen.ToString();
                            lblParentesco.Text = Imagenes[posRandom].Descripcion;

                            //string base64String = Convert.ToBase64String(Imagenes[posRandom].Imagen);
                            btnImageDos.ImageUrl = Imagenes[posRandom].Imagen;

                            btnImageUno.Visible = false;
                            btnImageTres.Visible = false;
                        }
                    }
                    else
                        Response.Redirect("~\\AdivinaAnimales.aspx?Error=err");
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
            csImagen Imagen = (new csImagenHandler()).Get(Convert.ToInt32(lblIdFotoUno.Text), out exceptionServices);

            if (!exceptionServices)
            {
                if (Imagen.Descripcion == lblParentesco.Text)
                    Response.Redirect("~\\AdivinaAnimales.aspx?Adivina=ex");
                else
                    Response.Redirect("~\\AdivinaAnimales.aspx?Adivina=err");
            }
            else
                Response.Redirect("~\\AdivinaAnimales.aspx?Error=err");
        }
        else if (btnImage.ID == "btnImageDos")
        {
            csImagen Imagen = (new csImagenHandler()).Get(Convert.ToInt32(lblIdFotoDos.Text), out exceptionServices);

            if (!exceptionServices)
            {
                if (Imagen.Descripcion == lblParentesco.Text)
                    Response.Redirect("~\\AdivinaAnimales.aspx?Adivina=ex");
                else
                    Response.Redirect("~\\AdivinaAnimales.aspx?Adivina=err");
            }
            else
                Response.Redirect("~\\AdivinaAnimales.aspx?Error=err");
        }
        else if (btnImage.ID == "btnImageTres")
        {
            csImagen Imagen = (new csImagenHandler()).Get(Convert.ToInt32(lblIdFotoTres.Text), out exceptionServices);

            if (!exceptionServices)
            {
                if (Imagen.Descripcion == lblParentesco.Text)
                    Response.Redirect("~\\AdivinaAnimales.aspx?Adivina=ex");
                else
                    Response.Redirect("~\\AdivinaAnimales.aspx?Adivina=err");
            }
            else
                Response.Redirect("~\\AdivinaAnimales.aspx?Error=err");
        }
    }
}