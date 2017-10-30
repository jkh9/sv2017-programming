// Examen de los temas 2 y 3, ejercicio 4
// Versión C (valor de "e" para n y n-1, repetidas veces)

using System;

public class Exam04c
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
            double anterior = 0;
            double denominador = 1;

            for (int i = 1; i <= sumandos; i++)
            {
                e = e + (1 / denominador);
                denominador = denominador * i;
                
                if (i == sumandos-1)
                    anterior = e;
            }
            Console.WriteLine("e vale aproximadamente " + e);
            Console.WriteLine("El valor anterior, para {0} sumandos es {1} ",
                sumandos-1, anterior);
            Console.WriteLine("La diferencia entre ellos es " +
                (e-anterior) );

            Console.Write("¿Cuántos sumandos desea en la aproximación de e"
                + " (pulse Intro para terminar)?: ");
            respuesta = Console.ReadLine();
        }
    }
}
