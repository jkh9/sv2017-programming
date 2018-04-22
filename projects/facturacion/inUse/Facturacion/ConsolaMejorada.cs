// Facturación, clase "ConsolaMejorada"

// Versiones:
// V0.08  20-Abr-2018 Moises Encinas, Raul Gogna, Pedro Coloma, Luis Selles
//          Creada la clase.

using System;

class ConsolaMejorada
{
    public static void Escribir(int x, int y, string texto, string color, bool line)
    {
        switch (color)
        {
            case "yellow":
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case "blue":
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case "red":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "white":
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case "black":
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            case "green":
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            default:
                break;
        }
        Console.SetCursorPosition(x, y);
        if (line)
        {
            Console.WriteLine(texto);
        }
        else
        {
            Console.Write(texto);
        }
    }

    public static string Pedir(int x, int y, int length)
    {
        Console.SetCursorPosition(x, y);
        Console.Write("["+new string('-',length)+"]");
        Console.SetCursorPosition((x + 1), y);
        string text;
        do
        {
            text = Console.ReadLine();
        }
        while (text.Length > length);

        return text;
    }
}
