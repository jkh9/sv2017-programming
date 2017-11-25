// Function IsAllUppercase
// Javier Saorín Vidal
// Version: a2 (Char.ToUpper)

using System;

public class Ex204
{
    public static bool IsAllUppercase(string word)
    {
        for (int i = 0; i < word.Length; i++)
            if (word[i] != Char.ToUpper(word[i]))
                return false;

        return true;
    }

    public static void Main()
    {
        if (IsAllUppercase("Hola"))
        {
            Console.WriteLine("Is all uppercase.");
        }
        else
        {
            Console.WriteLine("Is not all uppercase.");
        }
    }
}
