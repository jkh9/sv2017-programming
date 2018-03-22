// Display the permutations of the letters H, P, N, O

// Victor Tebar

using System;
using System.Text;

public class Ejer424{    
    public static void CountPermutations(string start,
        string alphabet,int validLength,ref int count)
    {
        if(start.Length == validLength)
        {
            Console.WriteLine(start);
            count++;
            return;
        }
        
        foreach(char c in alphabet)
        {
            if(!start.Contains(c.ToString()))
            {
                CountPermutations(start+c,alphabet,validLength,ref count);
            }
        }
    }
    
    public static void Main()
    {
        int count = 0;
        CountPermutations("","hpno",4,ref count);
        Console.WriteLine(count);
    }
}
