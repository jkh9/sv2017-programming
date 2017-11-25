// Function IsAllUppercase
// Miguel García Gil
// Version: b3 (returns the result of the comparison)


using System;

public class Ex204
{
    public static bool IsAllUppercase(string text)
    {
        return text == text.ToUpper();
    }
    
    public static void Main()
    {
        Console.WriteLine(IsAllUppercase("hola"));
        Console.WriteLine(IsAllUppercase("HOLA"));
        Console.WriteLine(IsAllUppercase("Hola"));
    }
}
