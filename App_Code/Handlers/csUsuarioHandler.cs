using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Descripción breve de csUsuarioHandler
/// </summary>
public class csUsuarioHandler : ObjectBase
{
    public csUsuarioHandler()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public csUsuario Get(int IdUsuario, out Boolean exceptionServies)
    {
        exceptionServies = false;
        csUsuario Usuario = new csUsuario();
        Data objData = new Data();
        string strQuery = string.Empty;

        try
        {
            objData.OpenConnection();

            MySqlParameter Params = new MySqlParameter("@IdUsuario", IdUsuario);
            Params.DbType = DbType.Int32;

            strQuery = "select * from tbUsuarios where IdUsuario = @IdUsuario;";

            DataTable dt = objData.ExecuteSPQuery(Params, strQuery);

            if (dt.Rows.Count != 0)
                Usuario.LoadFromDataRow(dt.Rows[0]);

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

        return Usuario;
    }

    public csUsuario Get(string Username, string Passwrd, out Boolean exceptionServies)
    {
        exceptionServies = false;
        csUsuario Usuario = new csUsuario();
        Data objData = new Data();
        string strQuery = string.Empty;

        try
        {
            objData.OpenConnection();

            MySqlParameter[] Params = new MySqlParameter[2];
            Params[0] = new MySqlParameter("@Username", Username);
            Params[0].DbType = DbType.String;
            Params[1] = new MySqlParameter("@Passwrd", Passwrd);
            Params[1].DbType = DbType.String;

            strQuery = "select * from tbUsuarios where Username = @Username and Passwrd = @Passwrd;";

            DataTable dt = objData.ExecuteSPQuery(Params, strQuery);

            if (dt.Rows.Count != 0)
                Usuario.LoadFromDataRow(dt.Rows[0]);

        }
        catch(Exception ex)
        {
            LogError(ex.Message + ex.StackTrace);
            exceptionServies = true;
        }
        finally
        {
            objData.CloseConnection();
            objData = null;
        }

        return Usuario;
    }

    public csUsuario CheckExist(string Username, out Boolean exceptionServies)
    {
        exceptionServies = false;
        csUsuario Usuario = new csUsuario();
        Data objData = new Data();
        string strQuery = string.Empty;

        try
        {
            objData.OpenConnection();

            MySqlParameter Params = new MySqlParameter("@Username", Username);
            Params.DbType = DbType.Int32;

            strQuery = "select * from tbUsuarios where Username = @Username;";

            DataTable dt = objData.ExecuteSPQuery(Params, strQuery);

            if (dt.Rows.Count != 0)
                Usuario.LoadFromDataRow(dt.Rows[0]);

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

        return Usuario;
    }

    public bool Add(csUsuario Usuario)
    {
        Data objData = new Data();
        string strQuery = string.Empty;
        bool error = false;

        try
        {
            objData.OpenConnection();

            MySqlParameter[] Params = new MySqlParameter[4];
            Params[0] = new MySqlParameter("IdRol", Usuario.IdRol);
            Params[0].DbType = DbType.Int32;
            Params[1] = new MySqlParameter("@Username", Usuario.Username);
            Params[1].DbType = DbType.String;
            Params[2] = new MySqlParameter("@Passwrd", Usuario.Passwrd);
            Params[2].DbType = DbType.String;
            Params[3] = new MySqlParameter("FechaAlta", Usuario.FechaAlta);
            Params[3].DbType = DbType.DateTime;

            strQuery = "insert into tbUsuarios(IdRol, Username, Passwrd, FechaAlta) values(@IdRol, @Username, @Passwrd, @FechaAlta);";

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

    public bool Add(csUsuario Usuario, csInformacionUsuario InformacionUsuario)
    {
        Data objData = new Data();
        string strQuery = string.Empty;
        int lastID = 0;
        bool error = false;

        try
        {
            objData.OpenConnection();

            MySqlParameter[] Params = new MySqlParameter[4];
            Params[0] = new MySqlParameter("IdRol", Usuario.IdRol);
            Params[0].DbType = DbType.Int32;
            Params[1] = new MySqlParameter("@Username", Usuario.Username);
            Params[1].DbType = DbType.String;
            Params[2] = new MySqlParameter("@Passwrd", Usuario.Passwrd);
            Params[2].DbType = DbType.String;
            Params[3] = new MySqlParameter("FechaAlta", Usuario.FechaAlta);
            Params[3].DbType = DbType.DateTime;

            strQuery = "insert into tbUsuarios(IdRol, Username, Passwrd, FechaAlta) values(@IdRol, @Username, @Passwrd, @FechaAlta);";

            objData.ExecuteSPNonQuery(Params, strQuery);

            //Obtener ultimo ID insertado (auto_increment)
            strQuery = "select last_insert_id() as LastID;";
            DataTable dt = objData.ExecuteQuery(strQuery);
            lastID = Convert.ToInt32(dt.Rows[0]["LastID"]);

            MySqlParameter[] _Params = new MySqlParameter[9];
            _Params[0] = new MySqlParameter("@IdUsuario", lastID);
            _Params[0].DbType = DbType.Int32;
            _Params[1] = new MySqlParameter("@Nombre", InformacionUsuario.Nombre);
            _Params[1].DbType = DbType.String;
            _Params[2] = new MySqlParameter("@ApellidoPaterno", InformacionUsuario.ApellidoPaterno);
            _Params[2].DbType = DbType.String;
            _Params[3] = new MySqlParameter("@ApellidoMaterno", InformacionUsuario.ApellidoMaterno);
            _Params[3].DbType = DbType.String;
            _Params[4] = new MySqlParameter("@Edad", InformacionUsuario.Edad);
            _Params[4].DbType = DbType.Int32;
            _Params[5] = new MySqlParameter("@FechaNacimiento", InformacionUsuario.FechaNacieminto);
            _Params[5].MySqlDbType = MySqlDbType.Date;
            _Params[6] = new MySqlParameter("@LugarOrigen", InformacionUsuario.LugarOrigen);
            _Params[6].MySqlDbType = MySqlDbType.String;
            _Params[7] = new MySqlParameter("@Foto", InformacionUsuario.Foto);
            //_Params[7].DbType = DbType.UInt32;
            _Params[8] = new MySqlParameter("@NombreFoto", InformacionUsuario.FotoNombre);
            _Params[8].MySqlDbType = MySqlDbType.String;

            strQuery = "insert into tbInformacionUsuarios(IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, Edad, FechaNacimiento, LugarOrigen, Foto, NombreFoto) " + 
                "values(@IdUsuario, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @Edad, @FechaNacimiento, @LugarOrigen, @Foto, @NombreFoto);";

            objData.ExecuteSPNonQuery(_Params, strQuery);
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