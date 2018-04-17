// Facturación, clase "Cabecera"

// Versiones:
// V0.06a 17-Abr-2018 
//      Moisés: Creada la clase
//      Nacho: Eliminado namespace

using System;

[Serializable]
class Cabecera
{
    public int Numero { get; set; }
    public DateTime Date { get; set; }
    public Cliente ClienteActual { get; set; }

    public Cabecera()
    {

    }
}
