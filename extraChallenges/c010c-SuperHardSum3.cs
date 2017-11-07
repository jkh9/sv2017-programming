/*Your amazing program should calculate the sum if the numbers given in each line, 
 *and output one line for each question with the response. Numbers can be negative, 
 *really big and lines contain extra spaces, so make your program resistant to input.
 * Your program will need to read from standard input, line by line till the end of 
 * the input. Consider each line a different question. For each line you read, output 
 * the sum of all the given numbers.*/

// Gonzalo Martinez

using System;

public class Challenge010
{
    public static void Main()
    {
        string data;
        int[] numbers;
        int sum = 0;
        int i = 0;
        
        do
        {
            data = Console.ReadLine();
            
            if(data != "")
            {
                numbers = new int[data.Length];
                string[] fragments = data.Split(new [] {' '}, 
                    StringSplitOptions.RemoveEmptyEntries);
                
                foreach(string num in fragments)
                {
                    numbers[i] = Convert.ToInt32(num);
                    sum += numbers[i];
                    i++;
                }
                Console.WriteLine(sum);
                i = 0;
                sum = 0;
            }
        }while(data != "");
    }
}
