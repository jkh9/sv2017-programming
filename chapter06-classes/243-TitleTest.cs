// TitleTest + Title

using System;

// -------------------------------------------------------------

class TitleTest
{
    static void Main(string[] args)
    {
        Title t = new Title();
        t.x = 10;
        t.y = 5;
        t.text = "Hello";
        t.Display();
    }
}

// -------------------------------------------------------------

class Title
{
    public int x;
    public int y;
    public string text;

    public void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(text);
    }
}
