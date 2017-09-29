/*Guillermo Pastor
*Crea un programa que reciba un entero de la entrada 
* estándar y escriba "Hola mundo." tantas veces como indique ese número.

Entrada de ejemplo

3

Salida de ejemplo

Hola mundo.
Hola mundo.
Hola mundo.

(Acepta el reto 116)

*/
using System;

public class ChallengeHelloWorld
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        while (n > 0)
        {
            Console.WriteLine("Hola mundo.");
            n = n - 1;
        }
    }
}
