// TitleTest + Init

public class TitleTest
{
    public static void Main(string[] args)
    {
        Title t = new Title(40, 20, "Hi!");
        t.Display();
        
        Title t2 = new Title("Welcome");
        t2.Display();
    }
}

/*---------------------------------------------------------------------------*/

public class Title
{
    private string text;
    private int x, y;

    public Title(int newX, 
        int newY, string newText)
    {
        x = newX;
        y = newY;
        text = newText;
    }
    
    public Title(string newText)
    {
        x = 40 - newText.Length/2;
        y = 12;
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
