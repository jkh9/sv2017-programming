//Guillermo Pator, Daniel Miquel, Querubin Santana
//Sabater, Lopez, Rebollo
class Rock : Still
{
    protected string type;
    protected string color;
    protected int weight;

    public Rock(string newtype, string newcolor, int newweight)
    {
        type = newtype;
        color = newcolor;
        weight = newweight;
    }

    public void SetType(string newtype)
    {
        type = newtype;
    }

    public void SetColor(string newcolor)
    {
        color = newcolor;
    }

    public void SetWeight(int newweight)
    {
        weight = newweight;
    }

    public string GetType()
    {
        return type;
    }

    public string GetColor()
    {
        return color;
    }

    public int GetWeight()
    {
        return weight;
    }
}