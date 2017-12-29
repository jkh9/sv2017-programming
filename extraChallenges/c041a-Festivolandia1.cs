// Lucía Navarro Vélez
// Festivolandia

/*
Los días pares de los meses pares son festivos, y los días impares de los meses 
impares también. El único día impar que es festivo en un mes par es el día de 
navidad, el 25 de diciembre. El resto de días son laborables.

Ejemplo de entrada
6
8 7
25 12
11 1
2 2
14 2
3 2

Ejemplo de salida
LABORABLE
FESTIVO
FESTIVO
FESTIVO
FESTIVO
LABORABLE
*/

using System;

public class Festivolandia
{
    public static void Main()
    {
        int casos, dia, mes;
        casos = Convert.ToInt32(Console.ReadLine());

        do
        {
            string[] dato = Console.ReadLine().Split();
            dia = Convert.ToInt32(dato[0]);
            mes = Convert.ToInt32(dato[1]);

            if ((mes % 2 == 0) && (dia % 2 == 0))
            {
                Console.WriteLine("FESTIVO");
            }
            else if ((mes % 2 == 1) && (dia % 2 == 1))
            {
                Console.WriteLine("FESTIVO");
            }
            else if (mes == 12 && dia == 25)
            {
                Console.WriteLine("FESTIVO");
            }
            else
            {
                Console.WriteLine("LABORABLE");
            }

            casos--;

        } while (casos != 0);
    }
}
