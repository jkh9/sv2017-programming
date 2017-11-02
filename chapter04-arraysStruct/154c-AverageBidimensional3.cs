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
        const int GROUPS = 2;
        const int PERSONS = 10;
        double[,] data = new double[GROUPS, PERSONS];

        for (int group = 0; group < GROUPS; group++)
        {
            for (int person = 0; person < PERSONS; person++)
            {
                Console.Write("Enter value #" +
                    (person + 1) + " in data " +
                    (group + 1) +" : ");
                data[group, person] = Convert.ToDouble(Console.ReadLine());
            }
        }

        for (int group = 0; group < GROUPS; group++)
        {
            double sum = 0;
            for (int person = 0; person < PERSONS; person++)
            {
                sum += data[group, person];
            }
            double average = sum / PERSONS;
            Console.WriteLine("Average of data "
                + (group+1) + " = " + average);
        }
    }
}
