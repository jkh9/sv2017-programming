// Facturación, clase principal ("Facturacion")

// Versiones:
// V0.01a 11-Abr-2018 Raúl Gogna: Lanza "VisorClientes"
// V0.01b 14-Abr-2018 Nacho: Comentario inicial

class Facturacion
{
    public static void Ejecutar()
    {
        VisorClientes visor = new VisorClientes();
        visor.Ejecutar();
    }

    public static void Main(string[] args)
    {
        Ejecutar();
    }
}
