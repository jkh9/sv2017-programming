// Challenge 093: Mascleta
// Max and min in a series 

// Input sample
// 3
// 5 10 1 22 33 4
// 1 10
// 3 1 1 2
// 
// Output sample
// 33 1
// 10 10
// 2 1

//Almudena Lopez

using System;

public class Challenge93
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < cases; i++)
        {
            string line = Console.ReadLine();
            string[] nums = line.Split(' ') ;
            int[] numsInt = new int[nums.Length];

            for (int k = 0; k < nums.Length; k++)
                numsInt[k] = Convert.ToInt32(nums[k]);

            int max = numsInt[1];
            int min = numsInt[1];

            for(int j = 0; j < nums.Length; j++)
            {
                max = max > numsInt[j] ? max : numsInt[j];
                min = min < numsInt[j] ? min : numsInt[j];
            }
            Console.WriteLine("{0} {1}", max, min);
        }
    }
}
