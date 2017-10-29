// Examen de los temas 2 y 3, ejercicio 1
// Versión D (incremento variable)

using System;

public class Exam01d
{
    public static void Main()
    {
        int number1, number2;
        int i;
        sbyte increment;
        
        Console.Write ("Enter first number: ");
        number1 = Convert.ToInt32 (Console.ReadLine());
        
        Console.Write ("Enter second number: ");
        number2 = Convert.ToInt32 (Console.ReadLine());
        
        increment = (sbyte) (number2 > number1 ? 1 : -1);

        for (i = number1; i != number2; i += increment)
            if (i != 0)
                Console.Write (i + " ");
        Console.WriteLine(number2);
        
        i = number1;
        while (i != number2)
        {
            if (i != 0)
                Console.Write (i + " ");
            i += increment;
        }
        Console.WriteLine(number2);
        
        i = number1;
        if (number1 != number2)
            do
            {
                if (i != 0)
                    Console.Write (i + " ");
                i += increment;
            }
            while(i != number2);
        Console.WriteLine(number2);
    }
}
