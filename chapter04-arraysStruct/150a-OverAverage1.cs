/*
Create an array containing 10 real numbers entered by the user. Then, 
show the values which are over the average.

Version 1: First Approach
*/

using System;

public class OverAverage1
{
    public static void Main()
    {
        double[] data = new double[10];

        // Let's ask for data
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter data: ");
            data[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Now let's calculate the average
        double sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += data[i];
        }
        double average = sum / 10;

        // And finally, let's display the ones over the average
        for (int i = 0; i < 10; i++)
        {
            if (data[i] > average)
            {
                Console.Write(data[i] + " ");
            }
        }
        Console.WriteLine();
    }
}
