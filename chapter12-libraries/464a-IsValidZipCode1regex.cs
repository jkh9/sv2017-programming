// Javier Cases Sempere

using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsValidZipCode(string s)
    {
        Regex r = new Regex(@"\A[0-5][0-9]{4}\z");
        return r.IsMatch(s);
    }

    public static void Main(string[] args)
    {
        string text = Console.ReadLine();

        if (IsValidZipCode(text))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Not valid");
    }
}
