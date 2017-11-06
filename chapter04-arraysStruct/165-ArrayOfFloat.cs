/*
Ask the user for 10 float numbers, store them in an array and then 
display the  negative ones which are in even positions (second 
position, fourth, sixth, eighth or tenth).
*/

using System;

public class ArrayOfFloat
{
    public static void Main()
    {
        const int SIZE = 10;
        float[] data = new float[SIZE];
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter value #" + (i + 1) + ": ");
            data[i] = Convert.ToSingle(Console.ReadLine());
        }

        for (int i = 1; i < SIZE; i+=2)
        {
            if (data[i] < 0)
                Console.Write(data[i]+" ");
        }
        Console.WriteLine();
    }
}
