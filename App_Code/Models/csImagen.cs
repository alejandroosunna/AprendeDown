using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de csImagen
/// </summary>
public class csImagen : ObjectBase
{
    public int IdImagen { get; set; }
    public int IdJuegoAdivina { get; set; }
    public string Descripcion { get; set; }
    public string Imagen { get; set; }

    public csImagen()
    {
        IdImagen = 0;
        IdJuegoAdivina = 0;
        Descripcion = "";
        Imagen = "";
    }

    public void LoadFromDataRow(DataRow dr)
    {
        IdImagen = (int)CheckDbNull(dr["IdImagen"], enumObjectType.intType);
        IdJuegoAdivina = (int)CheckDbNull(dr["IdJuegoAdivina"], enumObjectType.intType);
        Descripcion = (string)CheckDbNull(dr["Descripcion"], enumObjectType.strType);
        Imagen = (string)CheckDbNull(dr["Imagen"], enumObjectType.strType);
    }
}