/*Your amazing program should calculate the sum if the numbers given in each line, 
 *and output one line for each question with the response. Numbers can be negative, 
 *really big and lines contain extra spaces, so make your program resistant to input.
 * Your program will need to read from standard input, line by line till the end of 
 * the input. Consider each line a different question. For each line you read, output 
 * the sum of all the given numbers.*/

// Miguel García Gil

using System;

public class Challenge010
{
    public static void Main()
    {
        string data;
        string[] nums;
        long sum;
        do
        {
            sum = 0;
            data = Console.ReadLine();
            
            if (data != "")
            {
                nums = data.Split();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != "")
                    {
                        sum += Convert.ToInt64(nums[i]);
                    }
                }
                Console.WriteLine (sum);
            }
        }
        while (data != "");
    }
}
