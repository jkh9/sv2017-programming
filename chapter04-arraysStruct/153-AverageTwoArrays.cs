/*
Create a program to ask the user for 20 real numbers, store them in two arrays 
of 10 numbers each (named "data1" and "data2"), and then display the average of 
the values which are stored in the first array and then the average of the 
values in the second array.
*/

using System;

public class AverageTwoArrays
{
    public static void Main()
    {
        double[] data1 = new double[10];
        double[] data2 = new double[10];
        int i;

        for (i = 0; i < 10; i++)
        {
            Console.Write("Enter value #" + (i + 1) + " in data 1: ");
            data1[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (i = 0; i < 10; i++)
        {
            Console.Write("Enter value #" + (i + 1) + " in data 2: ");
            data2[i] = Convert.ToDouble(Console.ReadLine());
        }


        double sum = 0;
        for (i = 0; i < 10; i++)
        {
            sum += data1[i];
        }
        double average = sum / 10;
        Console.WriteLine("Average of data 1 = "+ average);

        sum = 0;
        for (i = 0; i < 10; i++)
        {
            sum += data2[i];
        }
        average = sum / 10;
        Console.WriteLine("Average of data 2 = "+ average);
    }
}
