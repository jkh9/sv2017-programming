/*
* Acepta 217, Qué lado de la calle?
* (c) Javier Saorín Vidal
*/

using System;

public class Ch002
{
    public static void Main()
    {
        int number;
        
        number = Convert.ToInt32(Console.ReadLine());
        
        while ( number != 0 )
        {
            if (number % 2 == 0)
                Console.WriteLine("DERECHA");
            else
                Console.WriteLine("IZQUIERDA");
                
            number = Convert.ToInt32(Console.ReadLine());
        }
    }
}

