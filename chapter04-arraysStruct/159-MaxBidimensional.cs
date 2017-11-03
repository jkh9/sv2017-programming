/*

Create a program to ask the user for 2 x 5 integer numbers, store them in a 2x5 
bidimensional array (named "data"), and then display the maximum of first half 
array, the maximum of the second half array and the gflobal maximum.

*/

using System;

public class MaxBidimensional
{
    public static void Main()
    {
        const int BLOCKS = 2;
        const int DATA_PER_BLOCK = 5;
        int[,] data = new int[BLOCKS, DATA_PER_BLOCK];
        int[] max = new int[BLOCKS];

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

        for (int block = 0; block < BLOCKS; block++)
        {
            max[block] = data[block, 0];
            for (int item = 1; item < DATA_PER_BLOCK; item++)
            {
                if (data[block, item] > max[block])
                    max[block] = data[block, item];
            }
            Console.WriteLine("Max of data "
                + (block + 1) + " = " + max[block]);
        }

        int globalMax = max[0];
        foreach (int m in max)
        {
            if (m > globalMax)
                globalMax = m;
        }
        Console.WriteLine("Global = " + globalMax);
    }
}
