// angel rebollo berna

using System;

public class Ex198
{
    public static bool IsPalindrome(string a)
    {
        
        string reversed = "";

        for (int i = 0; i < a.Length; i++)
        {
            reversed = a[i] + reversed;
        }

        if (reversed == a)
            return true;
        else
            return false;
    }

    public static void Main()
    {
        string a = Console.ReadLine();
        Console.WriteLine(IsPalindrome(a));
    }
}
