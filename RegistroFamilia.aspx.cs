using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistroFamilia : System.Web.UI.Page
{
    List<string> listParentesco = new List<string>()
    {
        "Padre",
        "Madre",
        "Hermano(a)",
        "Tio(a)",
    };

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
                for (int x = 0; x < listParentesco.Count; x++)
                {
                    parentescoDrop.Items.Add(listParentesco[x]);
                    parentescoDrop.Items[x].Value = listParentesco[x];
                }
            }
            else
                Response.Redirect("~\\Login.aspx");
        }
        else
            Response.Redirect("~\\Login.aspx");
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if(txtNombreCompleto.Text != "")
        {
            if (fileUpload.HasFile)
            {
                Boolean exceptionServices = false;
                csFoto Foto = new csFoto();
                Foto.IdInformacionUsuario = (new csInformacionUsuarioHandler()).Get(Convert.ToInt32(Session["IdUsuario"]), out exceptionServices).IdInformacionUsuario;
                if (!exceptionServices)
                {
                    Foto.Descripcion = parentescoDrop.Value;
                    Foto.NombreCompleto = txtNombreCompleto.Text;

                    using (BinaryReader reader = new BinaryReader(fileUpload.PostedFile.InputStream))
                    {
                        Foto.Foto = reader.ReadBytes(fileUpload.PostedFile.ContentLength);
                        Foto.FotoNombre = fileUpload.FileName;
                    }

                    if(!(new csFotoHandler()).Add(Foto))
                        Response.Write(@"<script language = 'javascript'>alert('Se guardo con exito.') </script>");
                    else
                        Response.Write(@"<script language = 'javascript'>alert('Eror en el servidor. Por favor intentelo mas tarde.') </script>");

                }
                else
                    Response.Write(@"<script language = 'javascript'>alert('Eror en el servidor. Por favor intentelo mas tarde.') </script>");
            }
            else
                Response.Write(@"<script language = 'javascript'>alert('Seleccione una foto.') </script>");
        }
        else
            Response.Write(@"<script language = 'javascript'>alert('Llene todos los campos.') </script>");
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\Index.aspx");
    }
}