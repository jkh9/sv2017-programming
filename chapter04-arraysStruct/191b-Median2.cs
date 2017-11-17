// Ask the user for several numbers and display their median.
// (Version 2: Array.Sort)

using System;

public class Median
{
    public static void Main()
    {
        Console.Write("How many data? ");
        int size = Convert.ToInt32(Console.ReadLine());
        double[] data = new double[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter data {0}: ", i + 1);
            data[i] = Convert.ToDouble(Console.ReadLine());
        }

        Array.Sort(data);

        double median = size % 2 == 1 ?  // Even size?
            data[size / 2] : 
            (data[size / 2] + data[(size / 2) - 1]) / 2.0;
        Console.WriteLine("The median is: " + median);
    }
}
