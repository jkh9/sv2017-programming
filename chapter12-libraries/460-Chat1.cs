// Javier Cases Sempere

using System;
using System.IO; // Para Stream
using System.Text; // Para Encoding
using System.Net; // Para Dns, IPAddress
using System.Net.Sockets; // Para NetworkStream

public class ComunicacionRed
{
    static string direccionPrueba = "localhost";
    static int puertoPrueba = 2112;
    private static void enviar(string direccion,
    int puerto, string frase)
    {
        TcpClient cliente = new TcpClient(direccion, puerto);
        NetworkStream conexion = cliente.GetStream();

        byte[] secuenciaLetras = Encoding.ASCII.GetBytes(frase);
        conexion.Write(secuenciaLetras, 0, secuenciaLetras.Length);
        conexion.Close();
        cliente.Close();
    }
    private static string esperar(string direccion, int puerto)
    {
        // Tratamos de hallar la primera IP que corresponde
        // a una dirección como "localhost"

        IPAddress direccionIP = Dns.GetHostEntry(direccion).AddressList[0];
    
            // Comienza la espera de información
        TcpListener listener = new TcpListener(direccionIP, puerto);
        listener.Start();
        TcpClient cliente = listener.AcceptTcpClient();
        NetworkStream conexion = cliente.GetStream();
        StreamReader lector = new StreamReader(conexion);

        string frase = lector.ReadToEnd();

        cliente.Close();
        listener.Stop();
        return frase;
    }
    public static void Main()
    {
        Console.WriteLine("Pulse 1 para recibir o 2 para enviar");
        string respuesta = Console.ReadLine();
        if (respuesta == "2") // Enviar
        {
            Console.Write("Enviando... ");
            enviar(direccionPrueba, puertoPrueba, "Prueba de texto");
            Console.WriteLine("Enviado");
        }
        else // Recibir
        {
            Console.WriteLine("Esperando... ");
            Console.WriteLine(esperar(direccionPrueba, puertoPrueba));
            Console.WriteLine("Recibido");
        }
    }
}
