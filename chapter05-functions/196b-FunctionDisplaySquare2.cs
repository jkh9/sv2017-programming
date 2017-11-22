// Javier Saorín Vidal

using System;

public class Ex196
{
    public static void DisplaySquare(char symbol, int size)
    {
        string line = new string(symbol, size);
        for (int i = 0; i < size; i++)
            Console.WriteLine(line);
    }

    public static void Main()
    {
        DisplaySquare('*', 5);
    }
}
