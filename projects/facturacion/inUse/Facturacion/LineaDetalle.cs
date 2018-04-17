// Facturación, clase "LineaDetalle"

// Versiones:
// V0.07a 17-Abr-2018 
//      Moisés: Creada la clase
//      Nacho: Eliminado namespace

using System;

[Serializable]
class LineaDetalle
{
    public Producto ProductoActual { get; set; }
    public int Cantidad { get; set; }

    public LineaDetalle()
    {

    }
}
