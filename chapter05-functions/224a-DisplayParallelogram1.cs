// DrawParallelogram
// Javier Saorín Vidal

using System;

public class Ex224
{
    public static void DrawParallelogram(int width, int height, char symbol)
    {
        string line = new String(symbol, width);
        for (int row = 0; row < height; row++)
        {
            string spaces = new String(' ', row);
            Console.WriteLine(spaces + line);
        }
    }
    public static void Main()
    {
        DrawParallelogram(10, 4, '*');
    }
}
