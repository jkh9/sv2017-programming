// TableTest + Table + Leg

// -------------------------------------------------------------


class TableTest
{
    static void Main(string[] args)
    {
        Table t = new Table();
        t.SetColor("Red");
        t.Open();
    }
}

// -------------------------------------------------------------

class Table
{
    private Leg myLeg;
    private string color;

    public void SetColor(string newColor)
    {
        color = newColor;
    }

    public string GetColor()
    {
        return color;
    }
        
    public void Open()
    {
        // TO DO
    }

    public void Close()
    {
        // TO DO
    }
}



// -------------------------------------------------------------

class Leg
{
    string color;
}
