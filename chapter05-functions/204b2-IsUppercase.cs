// Function IsAllUppercase
// Miguel García Gil
// Version: b2 (two "return", instead of a "bool")

using System;

public class Ex204
{
    public static bool IsAllUppercase(string text)
    {
        if (text == text.ToUpper())
            return true;
        else
            return false;
    }
    
    public static void Main()
    {
        Console.WriteLine(IsAllUppercase("hola"));
        Console.WriteLine(IsAllUppercase("HOLA"));
        Console.WriteLine(IsAllUppercase("Hola"));
    }
}
