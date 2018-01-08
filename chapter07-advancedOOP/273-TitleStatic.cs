/*

Create a class "Title". It will contain a static method "Display(text)" to 
display a text centered in the screen and a "Display(text, y)" to display a 
text centered in a certain row.

Test it with a "Main" program.

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


public class TitleTest
{
    public static void Main()
    {
        Title.Display("Hello");
        Title.Display("Bye!", 20);
    }
}
