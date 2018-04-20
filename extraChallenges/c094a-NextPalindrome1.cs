// Find the next palindrome after a given number

// Javier Saorín Vidal && DAM 2017-18

using System;
public class Challenge94
{
    public static bool IsPalindrome(int n)
    {
        string number = n.ToString();
        string number2 = "";
        char[] data = number.ToCharArray();
        Array.Reverse(data);
        number2 = new string(data);

        return number == number2;
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
            Console.Write("Calculating 20k data (might take over 2.5min)... ");
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
