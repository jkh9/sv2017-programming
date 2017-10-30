// Max and min in an array
// Pedro Luis Coloma

using System;

public class MaxMinArray
{
    public static void Main()
    {
        double [] data = new double[10];
        int i;
        double max, min;
        const  int SIZE = 10;

        for (i = 0; i < SIZE ; i++)
        {
            Console.Write("Enter value #" + (i+1) + ": ");
            data[i] = Convert.ToDouble(Console.ReadLine());
        }
        
        max = min = data[0];
        for (i = 1; i < SIZE ; i++)
        {
            if (data[i] > max)
            {
                max = data[i];
            }
            if (data[i] < min)
            {
                min = data[i];
            }        
        }
                
        Console.WriteLine("The max is {0} and then min is {1}.",
            max, min);        
    }
}
