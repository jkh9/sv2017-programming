// Function IsAllUppercase
// Miguel García Gil
// Version: b1 (original by Miguel)

using System;

public class Ex204
{
    public static bool IsAllUppercase(string text)
    {
        bool correct = false;
        if (text == text.ToUpper())
        {
            correct = true;
        }
        return correct;
    }
    public static void Main()
    {
        Console.WriteLine(IsAllUppercase("hola"));
        Console.WriteLine(IsAllUppercase("HOLA"));
        Console.WriteLine(IsAllUppercase("Hola"));
    }
}
