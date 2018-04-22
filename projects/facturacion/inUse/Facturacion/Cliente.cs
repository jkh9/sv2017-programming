// Facturación, clase "Cliente"

// Versiones:
// V0.02a 11-Abr-2018 Raúl Gogna: Propiedades y constructor
// V0.03a 12-Abr-2018 Raúl Gogna: Serializable
// v0.08a 20-Abr-2018 Moisés: Nuevo constructor cambios en las propiedades

using System;

[Serializable]
class Cliente
{
    public string Nombre { get; set; }
    public string Cif { get; set; }
    public string Domicilio { get; set; }
    public string Ciudad { get; set; }
    public int CodigoPostal { get; set; }
    public string Pais { get; set; }
    public int Telefono { get; set; }
    public string Email { get; set; }
    public string Contacto { get; set; }
    public string Observaciones { get; set; }

    public Cliente(string nombre, string cif, string domicilio, string ciudad,
        int codigoPostal, string pais, int telefono, string email,
        string contacto, string observaciones)
    {
        Nombre = nombre;
        Cif = cif;
        Domicilio = domicilio;
        Ciudad = ciudad;
        CodigoPostal = codigoPostal;
        Pais = pais;
        Telefono = telefono;
        Email = email;
        Contacto = contacto;
        Observaciones = observaciones;
    }

    public Cliente()
    {

    }
}
