// Exercise 152: Reverse a string
// Javier Cases Sempere

using System;

public class Ex152
{
    public static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();

        for (int i = text.Length - 1; i >= 0; i--)
            Console.Write(text[i]);

        Console.WriteLine();
    }
}
