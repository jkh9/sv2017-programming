// Examen de los temas 2 y 3, ejercicio 1
// Versión A (demasiado repetitiva)

using System;

public class Exam01a
{
    public static void Main()
    {
        int number1, number2;
        
        Console.Write ("Enter first number: ");
        number1 = Convert.ToInt32 (Console.ReadLine());
        
        Console.Write ("Enter second number: ");
        number2 = Convert.ToInt32 (Console.ReadLine());
        
        int i, j;
        
        if (number2 > number1)
        {
            for (i = number1; i <= number2; i++)
                if (i != 0)
                    Console.Write (i + " ");
            Console.WriteLine();
            
            i = number1;
            while (i <= number2)
            {
                if (i != 0)
                    Console.Write (i + " ");
                i++;
            }
            Console.WriteLine();
            
            i = number1;
            do
            {
                if (i != 0)
                    Console.Write (i + " ");
                i++;
            }
            while(i <= number2);
            Console.WriteLine();
        }
            
        else
        {
            for (j = number1; j >= number2; j--)
                if (j != 0)
                    Console.Write (j + " ");
            Console.WriteLine();
            
            j = number1;
            while (j >= number2)
            {
                if (j != 0)
                    Console.Write (j + " ");
                j--;
            }
            Console.WriteLine();
            
            j = number1;
            do
            {
                if (j != 0)
                    Console.Write (j + " ");
                j--;
            }
            while(j >= number2);
            Console.WriteLine();
        }
    }
}
