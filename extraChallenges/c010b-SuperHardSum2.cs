//Almudena Lopez Sanchez
/*
Your amazing program should calculate the sum if the numbers given in each line,
and output one line for each question with the response. Numbers can be 
negative, really big and lines contain extra spaces, so make your program 
resistant to input.

Your program will need to read from standard input, line by line till the end
of the input. Consider each line a different question. For each line you read,
output the sum of all the given numbers.
*/
using System;
public class Challenge10
{
    public static void Main()
    {
        string line;
        long sum;
        do
        {
            sum = 0;
            line = Console.ReadLine();
            if(line != "")
            {
                while(line.Contains("  "))  // No duplicated spaces
                    line = line.Replace("  "," ");
                
                foreach (string num in line.Trim().Split())
                    sum += Convert.ToInt64(num);
                Console.WriteLine(sum);
            }
        }
        while(line != "");
    }
}
