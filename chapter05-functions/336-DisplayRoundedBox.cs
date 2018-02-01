/*
Create a function DisplayRoundedBox, which displays a rounded box 
with a certain width and a certain height, as in this example (2 points):

DisplayRoundedBox(8,3);

/--------\
|        |
\--------/
*/

// Javier Saorin

using System;

class Program
{
    public static void DisplayRoundedBox(int width, int height)
    {
        string line = new string('-', width - 2);
        string spaces = new string(' ', width - 2);

        Console.WriteLine("/" + line + "\\");
        for (int i = 0; i < height - 2; i++)
            Console.WriteLine("|" + spaces + "|");
        Console.WriteLine("\\" + line + "/");
    }

    static void Main(string[] args)
    {
        DisplayRoundedBox(8, 3);
    }
}
