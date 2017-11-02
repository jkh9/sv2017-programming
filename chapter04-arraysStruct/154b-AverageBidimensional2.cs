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

        for (int j = 0; j < 2; j++)
        {
            for (i = 0; i < 10; i++)
            {
                Console.Write("Enter value #" +
                    (i + 1) + " in data " +
                    (j + 1) +" : ");
                data[j, i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        for (int j = 0; j < 2; j++)
        {
            double sum = 0;
            for (i = 0; i < 10; i++)
            {
                sum += data[j, i];
            }
            double average = sum / 10;
            Console.WriteLine("Average of data "
                + (j+1) + " = " + average);
        }
    }
}
