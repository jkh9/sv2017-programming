/*
Create an array containing 10 real numbers entered by the user. Then, 
show the values which are over the average.

Version 4: .Length
*/

using System;

public class OverAverage4
{
    public static void Main()
    {
        double[] data = new double[10];

        // Let's ask for data and calculate the average
        double sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            Console.Write("Enter data {0}: ", i+1);
            data[i] = Convert.ToDouble(Console.ReadLine());
            sum += data[i];
        }
        double average = sum / data.Length;

        // And finally, let's display the ones over the average
        Console.WriteLine("Average: "+average);
        Console.Write("Over the average: ");
        foreach (double d in data)
        {
            if (d > average)
            {
                Console.Write(d + " ");
            }
        }
        Console.WriteLine();
    }
}
