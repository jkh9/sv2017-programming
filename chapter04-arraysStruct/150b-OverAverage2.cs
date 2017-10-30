/*
Create an array containing 10 real numbers entered by the user. Then, 
show the values which are over the average.

Version 2: More friendly + const
*/

using System;

public class OverAverage2
{
    public static void Main()
    {
        const int SIZE = 10;
        double[] data = new double[SIZE];

        // Let's ask for data
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter data {0}: ", i+1);
            data[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Now let's calculate the average
        double sum = 0;
        for (int i = 0; i < SIZE; i++)
        {
            sum += data[i];
        }
        double average = sum / SIZE;

        // And finally, let's display the ones over the average
        Console.WriteLine("Average: "+average);
        Console.Write("Over the average: ");
        for (int i = 0; i < SIZE; i++)
        {
            if (data[i] > average)
            {
                Console.Write(data[i] + " ");
            }
        }
        Console.WriteLine();
    }
}
