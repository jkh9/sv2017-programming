// TitleTest + Init

public class TitleTest
{
    public static void Main(string[] args)
    {
        Title t = new Title();
        t.Init(40, 20, "Hi!");
        t.Display();
    }
}

/*---------------------------------------------------------------------------*/

public class Title
{
    private string text;
    private int x, y;

    public void Init(int newX, 
        int newY, string newText)
    {
        x = newX;
        y = newY;
        text = newText;
    }
    
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
