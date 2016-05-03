using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de csUsuario
/// </summary>
public class csUsuario : ObjectBase
{
    public int IdUsuario { get; set; }
    public int IdRol { get; set; }
    public string Username { get; set; }
    public string Passwrd { get; set; }
    public DateTime FechaAlta { get; set; }

    public csUsuario()
    {
        IdUsuario = 0;
        IdRol = 0;
        Username = "";
        Passwrd = "";
        FechaAlta = new DateTime();
    }

    public void LoadFromDataRow(DataRow dr)
    {
        IdUsuario = (int)CheckDbNull(dr["IdUsuario"], enumObjectType.intType);
        IdRol = (int)CheckDbNull(dr["IdRol"], enumObjectType.intType);
        Username = (string)CheckDbNull(dr["Username"], enumObjectType.strType);
        Passwrd = (string)CheckDbNull(dr["Passwrd"], enumObjectType.strType);
        FechaAlta = (DateTime)CheckDbNull(dr["FechaAlta"], enumObjectType.dateType);
    }
}