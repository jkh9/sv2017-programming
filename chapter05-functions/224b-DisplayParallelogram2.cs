// DrawParallelogram
// Javier Saorín Vidal

using System;

public class Ex224
{
    public static void DrawParallelogram(int width, int height, char symbol)
    {
        string line = new String(symbol, width);
        string spaces = "";
        for (int row = 0; row < height; row++)
        {
            Console.WriteLine(spaces + line);
            spaces += " ";
        }
    }
    public static void Main()
    {
        DrawParallelogram(10, 4, '*');
    }
}
