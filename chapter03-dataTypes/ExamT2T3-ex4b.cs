// Examen de los temas 2 y 3, ejercicio 4
// Versión B (sólo el valor de "e", repetidas veces)

using System;

public class Exam04b
{
    public static void Main()
    {
        Console.Write("¿Cuántos sumandos desea en la aproximación de e"
            + " (pulse Intro para terminar)? ");
        string respuesta = Console.ReadLine();
        while (respuesta != "")
        {
            int sumandos = Convert.ToInt32(respuesta);

            double e = 0;
            double denominador = 1;

            for (int i = 1; i <= sumandos; i++)
            {
                e = e + (1 / denominador);
                denominador = denominador * i;
            }
            Console.WriteLine("e vale aproximadamente " + e);

            Console.Write("¿Cuántos sumandos desea en la aproximación de e"
                + " (pulse Intro para terminar)?: ");
            respuesta = Console.ReadLine();
        }
    }
}
