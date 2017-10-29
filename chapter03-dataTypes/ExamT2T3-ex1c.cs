// Examen de los temas 2 y 3, ejercicio 1
// Versión C (compacta pero compleja)

using System;

public class Exam01c
{
    public static void Main()
    {
        int num1,num2,count;
        
        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        for(int i = num1; num1 > num2 ? i>=num2 : i<=num2;
            i += num1 > num2 ? -1 : 1)
            if(i != 0)
                Console.Write(i + " ");
        Console.WriteLine();
        
        count = num1;
        while(num1 > num2 ? count >= num2 : count <= num2)
        {
            if(count != 0)
                Console.Write(count + " ");
            if(num1 > num2)
                count--;
            else
                count++;
        }
        Console.WriteLine();    
        
        count = num1;
        do
        {
            if(count != 0)
                Console.Write(count + " ");
            if(num1 > num2)
                count--;
            else
                count++;
        }
        while(num1 > num2 ? count >= num2 : count <= num2);
    }
}
