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

// Javier Saorín Vidal

using System;
using System.Collections.Generic;
public class Challenge093
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int c = 0; c < cases; c++)
        {
            string line = Console.ReadLine();

            string[] nums = line.Split();
            List<int> numbers = new List<int>();

            for (int n = 1; n < nums.Length; n++)
            {
                numbers.Add(Convert.ToInt32(nums[n]));
            }

            numbers.Sort();
            Console.WriteLine(numbers[numbers.Count -1] + " " + numbers[0]);
        }
    }
}
