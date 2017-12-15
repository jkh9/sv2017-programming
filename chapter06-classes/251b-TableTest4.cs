// TableTest + Table + Leg (V4)

// -------------------------------------------------------------


/*

New in this version:

Leg:
- color: get, set
- height: get, set
- constructors: 
    color, height
    height("black")

Table:
- attribute "open"
- Leg: get, set
- constructors: 
    color, Leg
*/


class TableTest
{
    static void Main(string[] args)
    {
        Leg l = new Leg("red", 750);
        l.ShowStatus();
        l.SetHeight(740);
        l.SetColor("maroon");
        l.ShowStatus();

        Table t = new Table("white", l);
        t.ShowStatus();

        t.SetColor("grey");
        t.Close();
        t.ShowStatus();
    }
}


// -------------------------------------------------------------

class Table
{
    protected Leg myLeg;
    protected string color;
    protected bool open;

    public Table( string newColor, Leg newLeg)
    {
        color = newColor;
        myLeg = newLeg;
        open = true;
    }

    public void SetLeg(Leg newLeg)
    {
        myLeg = newLeg;
    }

    public Leg GetLeg()
    {
        return myLeg;
    }

    public void SetColor(string newColor)
    {
        color = newColor;
    }

    public string GetColor()
    {
        return color;
    }

    public bool IsOpen()
    {
        return open;
    }

    public void Open()
    {
        open = true;
    }

    public void Close()
    {
        open = false;
    }

    public void ShowStatus()
    {
        System.Console.WriteLine("I am a table");
        System.Console.WriteLine("My color is " + color);
        System.Console.WriteLine("Open? " + open);
        System.Console.WriteLine("About my leg...");
        myLeg.ShowStatus();
    }
}


// -------------------------------------------------------------


class Leg
{
    protected string color;
    protected int heightMm;

    public Leg(string newColor, int newHeightMm)
    {
        color = newColor;
        heightMm = newHeightMm;
    }

    public Leg(int newHeightMm)
    {
        color = "black";
        heightMm = newHeightMm;
    }

    public void SetColor(string newColor)
    {
        color = newColor;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetHeight(int newHeightMm)
    {
        heightMm = newHeightMm;
    }

    public int GetHeight()
    {
        return heightMm;
    }

    public void ShowStatus()
    {
        System.Console.WriteLine("I am a leg");
        System.Console.WriteLine("My color is " + color);
        System.Console.WriteLine("My height is " + heightMm);
    }
}
