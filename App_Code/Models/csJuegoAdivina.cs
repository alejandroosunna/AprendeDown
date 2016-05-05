using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de csJuegoAdivina
/// </summary>
public class csJuegoAdivina : ObjectBase
{
    public int IdJuegoAdivina { get; set; }
    public string Nombre { get; set; }

    public csJuegoAdivina()
    {
        IdJuegoAdivina = 0;
        Nombre = "";
    }

    public void LoadFromDataRow(DataRow dr)
    {
        IdJuegoAdivina = (int)CheckDbNull(dr["IdJuegoAdivina"], enumObjectType.intType);
        Nombre = (string)CheckDbNull(dr["Nombre"], enumObjectType.strType);
    }
}