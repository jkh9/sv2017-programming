// UnderlinedTitleTest + Get, Set
// Javier Saorín Vidal

public class UnderlinedTitleTest
{
    public static void Main(string[] args)
    {
        UnderlinedTitle t = new UnderlinedTitle();
        t.SetX(35);
        t.SetY(10);
        t.SetText("Hi, welcome to OOP!");
        t.Display();
    }
}


/*---------------------------------------------------------------------------*/

public class Title
{
    protected string text;
    protected int x, y;

    public void SetText(string newText)
    {
        text = newText;
    }

    public string GetText()
    {
        return text;
    }
    
    public void SetX(int newX)
    {
        x = newX;
    }

    public int GetX()
    {
        return x;
    }
    
    public void SetY(int newY)
    {
        y = newY;
    }

    public int GetY()
    {
        return y;
    }
    
    public void Display()
    {
        System.Console.SetCursorPosition(x, y);
        System.Console.Write(text);
    }
}


/*---------------------------------------------------------------------------*/

public class UnderlinedTitle : Title
{   
    public new void Display()
    {
        System.Console.SetCursorPosition(x, y);
        System.Console.Write(text);
        System.Console.SetCursorPosition(x, y+1);
        System.Console.Write( new string('-', text.Length) );
    }
}
