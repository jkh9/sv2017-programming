using System;

[Serializable]
class Factura
{
    public Cabecera CabeceraActual {get; set;}
    //public List<LineaDetalle> Lineas { get; set; }

    public Factura()
    {
        CabeceraActual = new Cabecera();
        //Lineas = new List<LineaDetalle>();
    }
}
