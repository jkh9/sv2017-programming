//Almudena Lopez Sanchez
using System;
public class DisplayTextBoxedEx
{
    public static void DisplayTextBoxed(string text)
    {
        string row = new string('-', text.Length + 4);
        Console.WriteLine("+" + row + "+");
        Console.WriteLine();
        Console.WriteLine("|  " + text + "  |");
        Console.WriteLine();
        Console.WriteLine("+" + row + "+");
    }

    public static void Main()
    {
        string text = Console.ReadLine();
        DisplayTextBoxed(text);
    }
}
