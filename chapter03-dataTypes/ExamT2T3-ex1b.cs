// Examen de los temas 2 y 3, ejercicio 1
// Versión B (demasiado repetitiva)

using System;

public class Exam01b
{
    public static void Main()
    {
        int n1,n2,i;
        
        Console.Write("First number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second number: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        //Parte A
        if (n1 < n2)
            for (i = n1; i <= n2 ; i++)
                if (n1 != 0)
                    Console.Write(i+" ");
        else 
            for (i = n1; i >= n2 ; i--)
                if (n1 != 0)
                    Console.Write(i+" ");
        Console.WriteLine();

        //Parte B
        i = n1;
        
        if (n1 < n2)
            while (i <= n2)
            {
                if (n1 != 0)
                    Console.Write(i+" ");
                i++;
            }
        else
            while (i >= n2)
            {
                if (n1 != 0)
                    Console.Write(i+" ");
                i--;
            }
        Console.WriteLine();
        
        //Parte C
        i = n1;
        
        if (n1 < n2)
            do
            {
                if (n1 != 0)
                    Console.Write(i+" ");
                i++;
            }
            while (i <= n2);
        else
            do
            {
                if (n1 != 0)
                    Console.Write(i+" ");
                i--;
            }
            while (i >= n2);
    }
}
