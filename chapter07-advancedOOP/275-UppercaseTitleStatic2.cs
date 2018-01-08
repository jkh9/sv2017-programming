/*

Create a new version of the exercise 274 (Title + overload + UppercaseTitle) 
with less repetitive code

*/


using System;

public class Title
{
    public static void Display(string text)
    {
        Display(text, 12);
    }

    public static void Display(string text, int row)
    {
        Console.SetCursorPosition(40 - text.Length / 2,
            row);
        Console.WriteLine(text);
    }
}


public class UppercaseTitle : Title
{
    public static new void Display(string text)
    {
        Title.Display( text.ToUpper() );
    }

    public static new void Display(string text, int row)
    {
        Title.Display(text.ToUpper(), row);
    }
}


public class TitleTest
{
    public static void Main()
    {
        Title.Display("Hello");
        Title.Display("Bye!", 20);

        UppercaseTitle.Display("A");
        UppercaseTitle.Display("Hello again", 15);
    }
}
