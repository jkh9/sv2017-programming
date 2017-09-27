//Ignacio Fuentes
//Times Table

using System;

public class Ex045
{
    public static void Main()
    {
        int n;
        int count = 0;
        
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        while (count <= 10)
        {
            Console.WriteLine("{0} x {1} = {2}", n, count, n * count);
            count = count + 1;
        }
    }   
}
