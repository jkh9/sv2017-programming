// Javier Saorín Vidal

using System;

public class Square
{
    public static void Main()
    {
        Console.Write("Enter width: ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height: ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter character: ");
        char symbol = Convert.ToChar(Console.ReadLine());

        string line = new String(symbol, width);
        string spacedLine = new String(' ', width - 2);

        Console.WriteLine(line);
        for (int row = 0; row < height - 2; row++)
        {
            Console.Write(symbol);
            Console.Write(spacedLine);
            Console.WriteLine(symbol);
        }
        Console.WriteLine(line);
    }
}
