//Guillermo Pastor Pastor
using System;

public class Ex214
{
    public static void Main()
    {
        string text = "Bye!";
        WriteReverse(text);
    }

    public static void WriteReverse(string text)
    {
        string reversed = "";
        foreach (char item in text)
        {
            reversed = item + reversed;
        }
        Console.WriteLine(reversed);
    }
}
