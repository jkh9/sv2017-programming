// Ask the user for a sentence and sort the chars in it.
// Then display the resulting string on screen.

using System;
using System.Text;

public class Ex187
{
    public static void Main()
    {
        string text = Console.ReadLine();
        char[] letters = text.ToCharArray();
        Array.Sort(letters);
        Console.WriteLine(new string(letters));
    }
}
