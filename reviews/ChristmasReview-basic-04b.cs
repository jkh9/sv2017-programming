// Marcos Cervantes Matamoros, corrección menor por Nacho (mayúsculas)
// Basico 28 de diciembre V2

/*
Crea un programa que pida al usuario su nombre y escriba un rectángulo que tenga
4 filas de altura y 4 nombres de anchura, así:

Dime tu nombre: Nacho
NachoNachoNachoNacho
Nacho__________Nacho
Nacho__________Nacho
NachoNachoNachoNacho

(los subrayados deberán aparecer en pantalla como espacios en blanco).

Crea tambien una variante del ejercicio anterior en la que el nombre introducido 
se muestre alternando mayúsculas y minúsculas (por ejemplo, “nAcho” se convertiría
en “NaChO”). Cada vez que se escriba el nombre, se debe hacer con un color 
escogido al azar (usando Console.ForegroundColor). */
using System;
public class Basico28DiciembreV2
{
    public static void EscribeEspacios(string nombre)
    {
        for (int i = 0; i < nombre.Length; i++)
        {
            Console.Write(" ");
        }
    }

    public static void EscribeAlternado(string nombre)
    {
        Random rnd = new Random();
        bool upper = true;
        foreach (char c in nombre)
        {
            Console.ForegroundColor = (ConsoleColor)rnd.Next(16);
            if (upper)
                Console.Write(Char.ToUpper(c));
            else
                Console.Write(Char.ToLower(c));
            upper = ! upper;
        }
    }

    public static void Main()
    {
        Console.Write("Introduce tu nombre: ");
        string nombre = Console.ReadLine();
        for (int fila = 0; fila < 4; fila++)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                if ((fila == 1 && columna == 1) || (fila == 1 && columna == 2) ||
                        (fila == 2 && columna == 1) || (fila == 2 && columna == 2))
                    EscribeEspacios(nombre);
                else
                    EscribeAlternado(nombre);

            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }
}
