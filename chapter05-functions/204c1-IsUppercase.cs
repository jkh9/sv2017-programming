// Function IsAllUppercase
// Moisés Encinas

using System;

class Ex204
{
    static bool IsAllUppercase(string a)
    {
        foreach (char item in a)
        {
            if (item >= 'a' && item <='z')
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine(IsAllUppercase("hola"));
        Console.WriteLine(IsAllUppercase("HOLA"));
        Console.WriteLine(IsAllUppercase("Hola"));
    }
}
