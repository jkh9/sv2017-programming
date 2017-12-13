// TitleTest + Get, Set
// Javier Saorín Vidal

public class TitleTest
{
    public static void Main(string[] args)
    {
        Title t = new Title();
        t.SetX(40);
        t.SetY(20);
        t.SetText("Hi!");
        t.Display();
    }
}

/*---------------------------------------------------------------------------*/

public class Title
{
    private string text;
    private int x, y;

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
