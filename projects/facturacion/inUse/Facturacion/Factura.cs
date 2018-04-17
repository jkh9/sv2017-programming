// Facturación, clase "Factura"

// Versiones:
// V0.06a 17-Abr-2018 
//      Moisés: Creada la clase
//      Nacho: Eliminado namespace, comentado lo relativo a LineaDetalle
// V0.07a 17-Abr-2018 Nacho: Descomentado lo relativo a LineaDetalle

using System;
using System.Collections.Generic;

[Serializable]
class Factura
{
    public Cabecera CabeceraActual {get; set;}
    public List<LineaDetalle> Lineas { get; set; }

    public Factura()
    {
        CabeceraActual = new Cabecera();
        Lineas = new List<LineaDetalle>();
    }
}
