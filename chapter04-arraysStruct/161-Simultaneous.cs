/*

Create a program to ask the user for 10 integer numbers, store them in a 
bidimensional arrays of 2x5 numbers, and then display the values which are 
stored simultaneously in both half arrays.

*/

using System;

public class Ex161
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

        for (int left = 0; left < DATA_PER_BLOCK; left++)
        {
            for (int right = 0; right < DATA_PER_BLOCK; right++)
            {
                if (data[0,left] == data[1,right])
                    Console.Write(data[0, left] + " ");
            }
        }
        Console.WriteLine();
    }
}
