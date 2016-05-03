using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistrarse_Click(object sender, EventArgs e)
    {
        if (txtNombre.Text != "" && txtPasswrd.Text != "" && txtNombre.Text != "" && txtApellidoPaterno.Text != "" && txtApellidoMaterno.Text != "" &&
            txtEdad.Text != "" && txtOrigen.Text != "")
        {
            if (Request["Fecha"] != null)
            {
                DateTime date = new DateTime();
                if (DateTime.TryParse(Request["Fecha"].ToString(), out date))
                {
                    Boolean exceptionServices = false;
                    csUsuario Usuario = (new csUsuarioHandler()).CheckExist(txtUsername.Text, out exceptionServices);
                    if (!exceptionServices)
                    {
                        if (txtUsername.Text != Usuario.Username)
                        {
                            if (fileUpload.HasFile)
                            {
                                Usuario = new csUsuario();

                                Usuario.IdRol = 3;
                                Usuario.Username = txtUsername.Text;
                                Usuario.Passwrd = txtPasswrd.Text;
                                Usuario.FechaAlta = DateTime.Now;

                                csInformacionUsuario InformacionUsuario = new csInformacionUsuario();
                                InformacionUsuario.Nombre = txtNombre.Text;
                                InformacionUsuario.ApellidoPaterno = txtApellidoPaterno.Text;
                                InformacionUsuario.ApellidoMaterno = txtApellidoMaterno.Text;
                                InformacionUsuario.Edad = Convert.ToInt32(txtEdad.Text);
                                InformacionUsuario.FechaNacieminto = Convert.ToDateTime(Request["Fecha"].ToString());
                                InformacionUsuario.LugarOrigen = txtOrigen.Text;

                                using (BinaryReader reader = new BinaryReader(fileUpload.PostedFile.InputStream))
                                {
                                    InformacionUsuario.Foto = reader.ReadBytes(fileUpload.PostedFile.ContentLength);
                                    InformacionUsuario.FotoNombre = fileUpload.FileName;
                                }

                                if (!(new csUsuarioHandler()).Add(Usuario, InformacionUsuario))
                                    Response.Redirect("~\\Login.aspx?Re=ex");
                                else
                                    Response.Write(@"<script language = 'javascript'>alert('Eror en el servidor. Por favor intentelo mas tarde.') </script>");
                            }
                            else
                                Response.Write(@"<script language = 'javascript'>alert('Seleccione una foto.') </script>");
                        }
                        else
                            Response.Write(@"<script language = 'javascript'>alert('El nombre de usuario que ingreso ya existe.') </script>");
                    }
                    else
                        Response.Write(@"<script language = 'javascript'>alert('Error en el servidor.') </script>");
                }
                else
                    Response.Write(@"<script language = 'javascript'>alert('Establezca una fecha valida.') </script>");
            }
            else
                Response.Write(@"<script language = 'javascript'>alert('Llene el campo de fecha de nacimiento.') </script>");
        }
        else
            Response.Write(@"<script language = 'javascript'>alert('Llene todos los campos.') </script>");


    }
}