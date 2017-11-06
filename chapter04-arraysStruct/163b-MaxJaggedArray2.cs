/*

Create a program to ask the user for several integer numbers, store them in a 
jagged array (named "data", for which the user will choose the size of each 
block), and then display the maximum of first half  array, the maximum of the 
second half array and the gflobal maximum.

(Version 2: .Length for each subarray) 

*/

using System;

public class MaxJaggedArray2
{
    public static void Main()
    {
        const int BLOCKS = 2;
        int[][] data = new int[BLOCKS][];
        int[] max = new int[BLOCKS];

        for (int block = 0; block < BLOCKS; block++)
        {
            Console.Write("Enter size of block " + (block+1)+": ");
            int size = Convert.ToInt32(Console.ReadLine());
            data[block] = new int[size];
        }

        for (int block = 0; block < BLOCKS; block++)
        {
            for (int item = 0; item < data[block].Length; item++)
            {
                Console.Write("Enter value #" +
                    (item + 1) + " in block " +
                    (block + 1) + " : ");
                data[block][item] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int block = 0; block < BLOCKS; block++)
        {
            max[block] = data[block][0];
            for (int item = 1; item < data[block].Length; item++)
            {
                if (data[block][item] > max[block])
                    max[block] = data[block][item];
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
