// TableTest + Table + Leg

// -------------------------------------------------------------


class TableTest
{
    static void Main(string[] args)
    {
        Table t = new Table();
        t.color = "Red";
        t.Open();
    }
}

// -------------------------------------------------------------

class Table
{
    Leg myLeg;
    public string color;

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
