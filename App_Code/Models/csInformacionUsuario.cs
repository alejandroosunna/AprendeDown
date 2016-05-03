using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de csInformacionUsuario
/// </summary>
public class csInformacionUsuario : ObjectBase
{
    public int IdInformacionUsuario { get; set; }
    public int IdUsuario { get; set; }
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public int Edad { get; set; }
    public DateTime FechaNacieminto { get; set; }
    public string LugarOrigen { get; set; }
    public byte[] Foto { get; set; }
    public string FotoNombre { get; set; }

    public csInformacionUsuario()
    {
        IdInformacionUsuario = 0;
        IdUsuario = 0;
        Nombre = "";
        ApellidoPaterno = "";
        ApellidoMaterno = "";
        Edad = 0;
        FechaNacieminto = new DateTime();
        LugarOrigen = "";
        Foto = new byte[0];
        FotoNombre = "";
    }

    public void LoadFromDataRow(DataRow dr)
    {
        IdInformacionUsuario = (int)CheckDbNull(dr["IdInformacionUsuario"], enumObjectType.intType);
        IdUsuario = (int)CheckDbNull(dr["IdUsuario"], enumObjectType.intType);
        Nombre = (string)CheckDbNull(dr["Nombre"], enumObjectType.strType);
        ApellidoPaterno = (string)CheckDbNull(dr["ApellidoPaterno"], enumObjectType.strType);
        ApellidoMaterno = (string)CheckDbNull(dr["ApellidoMaterno"], enumObjectType.strType);
        Edad = (int)CheckDbNull(dr["Edad"], enumObjectType.intType);
        FechaNacieminto = (DateTime)CheckDbNull(dr["FechaNacimiento"], enumObjectType.dateType);
        LugarOrigen = (string)CheckDbNull(dr["LugarOrigen"], enumObjectType.strType);
        Foto = (byte[])CheckDbNull(dr["Foto"], enumObjectType.byteArrayType);
        FotoNombre = (string)CheckDbNull(dr["FotoNombre"], enumObjectType.strType);
    }
}