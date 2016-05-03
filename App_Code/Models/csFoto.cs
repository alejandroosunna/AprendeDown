using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de csFoto
/// </summary>
public class csFoto : ObjectBase
{
    public int IdFoto { get; set; }
    public int IdInformacionUsuario { get; set; }
    public string Descripcion { get; set; }
    public string NombreCompleto { get; set; }
    public byte[] Foto { get; set; }
    public string FotoNombre { get; set; }

    public csFoto()
    {
        IdFoto = 0;
        IdInformacionUsuario = 0;
        Descripcion = "";
        NombreCompleto = "";
        Foto = new byte[0];
        FotoNombre = "";
    }

    public void LoadFromDataRow(DataRow dr)
    {
        IdFoto = (int)CheckDbNull(dr["IdFoto"], enumObjectType.intType);
        IdInformacionUsuario = (int)CheckDbNull(dr["IdInformacionUsuario"], enumObjectType.intType);
        Descripcion = (string)CheckDbNull(dr["Descripcion"], enumObjectType.strType);
        NombreCompleto = (string)CheckDbNull(dr["NombreCompleto"], enumObjectType.strType);
        Foto = (byte[])CheckDbNull(dr["Foto"], enumObjectType.byteArrayType);
        FotoNombre = (string)CheckDbNull(dr["FotoNombre"], enumObjectType.strType);
    }
}