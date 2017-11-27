// Javier Cases Sempere

using System;

public class Ex211
{
    public static void WriteCentered(string text)
    {
        const byte width = 80;
        for (int i = 0; i < (width / 2) - (text.Length / 2); i++)
            Console.Write(" ");
        Console.WriteLine(text);
    }
        
    public static void WriteCenteredTriangle(int size, char symbol)
    {
        while (size > 0)
        {
            WriteCentered( new string(symbol, size) );
            size -= 2;
        }
    }

    public static void Main()
    {
        Console.Write("Size? ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Char? ");
        char symbol = Convert.ToChar(Console.ReadLine());
        WriteCenteredTriangle(size, symbol);
    }
}
