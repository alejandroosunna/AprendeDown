using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
/// Descripción breve de csInformacionUsuarioHandler
/// </summary>
public class csInformacionUsuarioHandler : ObjectBase
{
    public csInformacionUsuarioHandler()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public csInformacionUsuario Get(int IdUsuario, out bool exceptionServies)
    {
        exceptionServies = false;
        csInformacionUsuario InformacionUsuario = new csInformacionUsuario();
        Data objData = new Data();
        string strQuery = string.Empty;

        try
        {
            objData.OpenConnection();

            MySqlParameter Params = new MySqlParameter("@IdUsuario", IdUsuario);

            strQuery = "select * from tbInformacionUsuarios where IdUsuario = @IdUsuario;";

            DataTable dt = objData.ExecuteSPQuery(Params, strQuery);

            if (dt.Rows.Count != 0)
                InformacionUsuario.LoadFromDataRow(dt.Rows[0]);

        }
        catch (Exception ex)
        {
            LogError(ex.Message + ex.StackTrace);
            exceptionServies = true;
        }
        finally
        {
            objData.CloseConnection();
            objData = null;
        }

        return InformacionUsuario;
    }
}