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
