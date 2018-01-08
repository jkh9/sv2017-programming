/*

Create a class "UppercaseTitle", inheriting from "Title". Its method 
"Display(text)" will display the text using uppercase letters and centered on 
the screen. Make the same changes for "Display(text, y)"

*/


using System;

public class Title
{
    public static void Display(string text)
    {
        Console.SetCursorPosition(40 - text.Length / 2,
            12);
        Console.WriteLine(text);
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
        Console.SetCursorPosition(40 - text.Length / 2,
            12);
        Console.WriteLine(text.ToUpper());
    }

    public static new void Display(string text, int row)
    {
        Console.SetCursorPosition(40 - text.Length / 2,
            row);
        Console.WriteLine(text.ToUpper());
    }
}


public class TitleTest
{
    public static void Main()
    {
        Title.Display("Hello");
        Title.Display("Bye!", 20);

        UppercaseTitle.Display("Hello again", 15);
    }
}
