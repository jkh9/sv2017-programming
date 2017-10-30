// Examen de los temas 2 y 3, ejercicio 4
// Versión A (sólo el valor de "e", sin repetir)

using System;

public class Exam04a
{
    public static void Main()
    {
        Console.Write("¿Cuántos sumandos desea en la aprox. de e? ");
        int sumandos = Convert.ToInt32(Console.ReadLine());

        double e = 0;
        double denominador = 1;

        for (int i = 1; i <= sumandos; i++)
        {
            e = e + (1 / denominador);
            denominador = denominador * i;
        }
        Console.WriteLine("e vale aproximadamente " + e);
    }
}
