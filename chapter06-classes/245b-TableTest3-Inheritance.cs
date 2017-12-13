// TableTest + Table + Leg

// -------------------------------------------------------------


class TableTest
{
    static void Main(string[] args)
    {
        Table t = new Table();
        t.SetColor("Red");
        t.Open();

        SmallTable table2 = new SmallTable();
        table2.Open();
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

class SmallTable : Table
{
    // Nothing new here... yet
}

// -------------------------------------------------------------

class Leg
{
    string color;
}
