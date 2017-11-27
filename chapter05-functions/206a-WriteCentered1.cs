// Javier Cases Sempere

using System;

public class Ex206
{
    public static void WriteCentered(string text)
    {
        const byte width = 80;
        for (int i = 0; i < (width / 2) - (text.Length / 2); i++)
            Console.Write(" ");
        Console.WriteLine(text);
    }
    
    public static void Main()
    {
        WriteCentered("****");
    }
}
