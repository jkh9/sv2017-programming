// Display all the variations from aaaaa to zzzzz 
// (5 chars, letters a to z in the English alphabet... 
// and count them)

// Note: the answer should be 26^5 = 11,881,376

using System;

public class Combinations2
{
    public static void Main()
    {
        int count = 0;
        for (char c1 = 'a'; c1 <= 'z'; c1++)
            for (char c2 = 'a'; c2 <= 'z'; c2++)
                for (char c3 = 'a'; c3 <= 'z'; c3++)
                    for (char c4 = 'a'; c4 <= 'z'; c4++)
                        for (char c5 = 'a'; c5 <= 'z'; c5++)
                        {
                            Console.Write(""+c1+c2+c3+c4+c5 + " ");
                            count ++;
                        }
        
        Console.WriteLine("  Combinations found: "+count);
    }
}
