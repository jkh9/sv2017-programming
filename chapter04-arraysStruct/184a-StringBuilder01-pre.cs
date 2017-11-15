using System;
using System.Text;

public class StringBuilder01pre
{
    
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        StringBuilder s = new StringBuilder(sentence);
        s[1] = 'a';

        Console.WriteLine(s);
    }
}
