// Javier Cases Sempere

using System;
using System.Text.RegularExpressions;

class RegExHex
{
    public static bool IsHex(string s)
    {
        Regex r = new Regex(@"\A[0-9a-fA-F]+\z");
        return r.IsMatch(s);
    }

    public static void Main(string[] args)
    {
        string text = Console.ReadLine();

        if (IsHex(text))
            Console.WriteLine("Valid hex");
        else
            Console.WriteLine("Not valid hex");
    }
}
