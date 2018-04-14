/*
 * Raul Gogna
 * 
 */
using System;


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
