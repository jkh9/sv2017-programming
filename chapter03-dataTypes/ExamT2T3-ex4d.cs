// Examen de los temas 2 y 3, ejercicio 4
// Versión D (ligeramente mejorada)

using System;

public class Exam04d
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

            // Recorremos sólo hasta el penúltimo
            for (int i = 1; i <= sumandos-1; i++)
            {
                e += 1 / denominador;
                denominador *= i;
            }
            
            // Y el último oasi lo damos fuera
            anterior = e;
            e += 1 / denominador;
            
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
