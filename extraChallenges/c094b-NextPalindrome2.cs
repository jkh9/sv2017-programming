// Find the next palindrome after a given number

// Javier Saorín Vidal

using System;
public class Challenge94b
{
    public static bool IsPalindrome(int n)
    {
        string number = n.ToString();
        for (int i = 0; i < number.Length / 2; i++)
        {
            if (number[i] != number[number.Length - (i + 1)])
            {
                return false;
            }
        }
        return true;
    }

    public static int DistanceToNextPalindrome(int start)
    {
        int n = start + 1;
        while (!IsPalindrome(n))
        {
            n++;
        }
        return n - start;
    }


    public static void Main()
    {
        #if true
            int d;
            Console.Write("Calculating 20k data (might take over 40sec)... ");
            DateTime start = DateTime.Now;
            for (int i = 0; i < 2000000000; i+=100001)
            {
                d = DistanceToNextPalindrome(i);
            }
            Console.WriteLine(DateTime.Now-start);
            Console.WriteLine("Now you can enter real data...");
        #endif

        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( DistanceToNextPalindrome(n) );
        }
    }
}

