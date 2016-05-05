using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
/// Descripción breve de csFotoHandler
/// </summary>
public class csFotoHandler : ObjectBase
{
    public csFotoHandler()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public csFoto Get(int IdFoto, out bool exceptionServices)
    {
        exceptionServices = false;
        csFoto Foto = new csFoto();
        Data objData = new Data();
        string strQuery = string.Empty;

        try
        {
            objData.OpenConnection();

            MySqlParameter Param = new MySqlParameter("@IdFoto", IdFoto);
            Param.DbType = DbType.Int32;

            strQuery = "select * from tbFotos where IdFoto = @IdFoto;";

            DataTable dt = objData.ExecuteSPQuery(Param, strQuery);

            if (dt.Rows.Count != 0)
                Foto.LoadFromDataRow(dt.Rows[0]);
        }
        catch (Exception ex)
        {
            LogError(ex.Message + ex.StackTrace);
            exceptionServices = true;
        }
        finally
        {
            objData.CloseConnection();
            objData = null;
        }

        return Foto;
    }

    public List<csFoto> GetList(int IdInformacionUsuario, out bool exceptionServices)
    {
        exceptionServices = false;
        List<csFoto> Fotos = new List<csFoto>();
        Data objData = new Data();
        string strQuery = string.Empty;

        try
        {
            objData.OpenConnection();

            MySqlParameter Param = new MySqlParameter("@IdInformacionUsuario", IdInformacionUsuario);
            Param.DbType = DbType.Int32;

            strQuery = "select * from tbFotos where IdInformacionUsuario = @IdInformacionUsuario;";

            DataTable dt = objData.ExecuteSPQuery(Param, strQuery);

            for(int x = 0; x < dt.Rows.Count; x++)
            {
                csFoto Foto = new csFoto();
                Foto.LoadFromDataRow(dt.Rows[x]);
                Fotos.Add(Foto);
            }
        }
        catch(Exception ex)
        {
            LogError(ex.Message + ex.StackTrace);
            exceptionServices = true;
        }
        finally
        {
            objData.CloseConnection();
            objData = null;
        }

        return Fotos;
    }

    public bool Add(csFoto Foto)
    {
        Data objData = new Data();
        string strQuery = string.Empty;
        bool error = false;

        try
        {
            objData.OpenConnection();

            MySqlParameter[] Params = new MySqlParameter[5];
            Params[0] = new MySqlParameter("IdInformacionUsuario", Foto.IdInformacionUsuario);
            Params[0].DbType = DbType.Int32;
            Params[1] = new MySqlParameter("@Descripcion", Foto.Descripcion);
            Params[1].DbType = DbType.String;
            Params[2] = new MySqlParameter("@NombreCompleto", Foto.NombreCompleto);
            Params[2].DbType = DbType.String;
            Params[3] = new MySqlParameter("Foto", Foto.Foto);
            //Params[3].DbType = DbType.DateTime;
            Params[4] = new MySqlParameter("@FotoNombre", Foto.FotoNombre);
            Params[4].DbType = DbType.String;

            strQuery = "insert into tbFotos(IdInformacionUsuario, Descripcion, NombreCompleto, Foto, FotoNombre) values(@IdInformacionUsuario, @Descripcion, @NombreCompleto, @Foto, @FotoNombre);";

            objData.ExecuteSPNonQuery(Params, strQuery);
        }
        catch (Exception ex)
        {
            LogError(ex.Message + ex.StackTrace);
            error = true;
        }
        finally
        {
            objData.CloseConnection();
            objData = null;
        }

        return error;
    }
}