// Display all the variations from aaaaa to zzzzz 
// (5 chars, letters a to z in the English alphabet... 
// up to 8 letters... and count them)

// Note: the answer for 5 to 8 should be 26^5 + 26^6 + 26^7 + 26^8 
//     = 11,881,376 + 308,915,776 + 8,031,810,176 + 208,827,064,576 
//     = 217,179,671,904

using System;

public class Combinations3
{
    public static void DisplayFrom(string startPoint, string alphabet,
        int minLength, int maxLength, ref long count)
    {
        // If we have finished this branch, we stop
        int len = startPoint.Length;
        if (len > maxLength)
            return;

        // If this is a valid solution, we show it and count it
        if ((len >= minLength) && (len <= maxLength))
        {
            Console.WriteLine(startPoint);
            count++;
            // if (count % 1000000 == 0) 
            //    Console.WriteLine(count / 1000000);
        }

        // Anyway, we proceed to a more complete solution
        foreach (char c in alphabet)
            DisplayFrom(startPoint + c, alphabet, minLength, maxLength, ref count);
    }

    public static void Main()
    {
        long count = 0;
        DisplayFrom("", "abcdefghijklmnopqrstuvwxyz", 5, 8, ref count);

        Console.WriteLine("  Combinations found: " + count);
    }
}
