// Ex.118 - Nested counters, goto
// Create a program with two nested loops:
// 
// In the outer loop, "i" must go from 1 to 10
// In the inner loop, "j" must go from 20 to 30 
//     with a step of 2
// Display the values of "i" and "j"
// You must interrupt the loop when "i" 
//     becomes 3 and "j" is greater than 25.

// Jose Vilaplana

using System;
public class GoTo2
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 20; j <= 30; j +=2)
            {
                if ((i == 3) && (j > 25))
                    goto end;
                Console.Write("{0} {1} ; ", i, j);
            }
        }
        
        end:
        
        Console.WriteLine();
    }
}
