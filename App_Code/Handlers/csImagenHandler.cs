using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
/// Descripción breve de csImagenHandler
/// </summary>
public class csImagenHandler : ObjectBase
{
    public csImagenHandler()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public csImagen Get(int IdImagen, out bool exceptionServices)
    {
        exceptionServices = false;
        csImagen Imagen = new csImagen();
        Data objData = new Data();
        string strQuery = string.Empty;

        try
        {
            objData.OpenConnection();

            MySqlParameter Param = new MySqlParameter("@IdImagen", IdImagen);
            Param.DbType = DbType.Int32;

            strQuery = "select * from tbImagenes where IdImagen = @IdImagen;";

            DataTable dt = objData.ExecuteSPQuery(Param, strQuery);

            if (dt.Rows.Count != 0)
                Imagen.LoadFromDataRow(dt.Rows[0]);
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

        return Imagen;
    }

    public List<csImagen> GetList(int IdJuegoAdivina, out bool exceptionServices)
    {
        exceptionServices = false;
        List<csImagen> Imagenes = new List<csImagen>();
        Data objData = new Data();
        string strQuery = string.Empty;

        try
        {
            objData.OpenConnection();

            MySqlParameter Param = new MySqlParameter("@IdJuegoAdivina", IdJuegoAdivina);
            Param.DbType = DbType.Int32;

            strQuery = "select * from tbImagenes where IdJuegoAdivina = @IdJuegoAdivina;";

            DataTable dt = objData.ExecuteSPQuery(Param, strQuery);

            for (int x = 0; x < dt.Rows.Count; x++)
            {
                csImagen Imagen = new csImagen();
                Imagen.LoadFromDataRow(dt.Rows[x]);
                Imagenes.Add(Imagen);
            }
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

        return Imagenes;
    }
}