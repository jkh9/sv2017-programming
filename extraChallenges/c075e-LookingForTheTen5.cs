// Gonzalo Martinez
// Challenge 75 - Looking for the ten

/*
Input examples

9,10,10,9
8,9
0,0,0,0,0,0,0,0,0,0,0,0,0
10,10,10,10

Output examples

0
4
247
0


The problem you must solve:

For the next entry, write a program that finds the answer.
7,7,10,10,4,6,4,6,0,6,7,4,6,6,9

The answer you should obtain is:
101
*/

using System;

public class Challenge075
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] split = input.Split(',');
        
        int tasksRequired = 0;
        double avg, sum = 0;
        
        foreach(string s in split)
            sum += Convert.ToDouble(s);
        avg = sum / split.Length;
        
        if(avg >= 9.5)
            tasksRequired = 0;
        else
        {
            bool done = false;
            int count = split.Length;
            
            do
            {
                if(!done)
                {
                    sum += 10;
                    count++;
                    tasksRequired++;
                    avg = sum / count;
                    
                    if(avg >= 9.5)
                        done = true;
                }
            }while(!done);
        }
        Console.WriteLine(tasksRequired);
    }
}
