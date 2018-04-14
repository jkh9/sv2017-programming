// Facturación, clase "Cliente"

// Versiones:
// V0.02a 11-Abr-2018 Raúl Gogna: Propiedades y constructor

class Cliente
{
    public string Nombre { get; set; }
    public string Cif { get; set; }
    public string Domicilio { get; set; }
    public string Ciudad { get; set; }
    public string CodigoPostal { get; set; }
    public string Pais { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Contacto { get; set; }
    public string Observaciones { get; set; }

    public Cliente(string nombre, string cif, string domicilio, string ciudad,
        string codigoPostal, string pais, string telefono, string email,
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

}