// Javier Saorín Vidal
using System;
public class Ex206
{
    public static void WriteCentered(string word)
    {
        string spaces = new string(' ', 40 - (word.Length / 2));
        Console.WriteLine(spaces + word);
    }
    
    public static void Main()
    {
        WriteCentered("xxxx");
    }
}
