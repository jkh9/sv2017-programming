/*

Create a program to ask the user for 2 x 5 integer numbers, store them in a 2x5 
bidimensional array (named "data"), and then display the global maximum.

*/

using System;

public class MaxBidimensional2
{
    public static void Main()
    {
        const int BLOCKS = 2;
        const int DATA_PER_BLOCK = 5;
        int[,] data = new int[BLOCKS, DATA_PER_BLOCK];

        for (int block = 0; block < BLOCKS; block++)
        {
            for (int item = 0; item < DATA_PER_BLOCK; item++)
            {
                Console.Write("Enter value #" +
                    (item + 1) + " in block " +
                    (block + 1) + " : ");
                data[block, item] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int globalMax = data[0,0];
        foreach (int m in data)
        {
            if (m > globalMax)
                globalMax = m;
        }
        Console.WriteLine("Max = " + globalMax);
    }
}
