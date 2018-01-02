//Marcos Cervantes Matamoros
//Basico 28 de diciembre 1
/*
Crea un programa que pida al usuario su nombre y escriba un rectángulo que tenga
4 filas de altura y 4 nombres de anchura, así:

Dime tu nombre: Nacho
NachoNachoNachoNacho
Nacho__________Nacho
Nacho__________Nacho
NachoNachoNachoNacho

(los subrayados deberán aparecer en pantalla como espacios en blanco).
*/
using System;
public class Basico28Diciembre1
{
    public static void EscribeEspacios(string nombre)
    {
        for (int i = 0; i < nombre.Length; i++)
        {
            Console.Write(" ");
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
                    Console.Write(nombre);

            }
            Console.WriteLine();
        }
    }
}
