/*
Create a program to ask the user for 20 real numbers, store them in a 2x10 
bidimensional array (named "data"), and then display the average of the values 
which are stored in the first half array and then the average of the values in 
the second half array.
*/

using System;

public class AverageBidimensional
{
    public static void Main()
    {
        double[,] data = new double[2,10];
        int i;

        for (i = 0; i < 10; i++)
        {
            Console.Write("Enter value #" + (i + 1) + " in data 1: ");
            data[0,i] = Convert.ToDouble(Console.ReadLine());
        }
        for (i = 0; i < 10; i++)
        {
            Console.Write("Enter value #" + (i + 1) + " in data 2: ");
            data[1,i] = Convert.ToDouble(Console.ReadLine());
        }


        double sum = 0;
        for (i = 0; i < 10; i++)
        {
            sum += data[0,i];
        }
        double average = sum / 10;
        Console.WriteLine("Average of data 1 = "+ average);

        sum = 0;
        for (i = 0; i < 10; i++)
        {
            sum += data[1,i];
        }
        average = sum / 10;
        Console.WriteLine("Average of data 2 = "+ average);
    }
}
