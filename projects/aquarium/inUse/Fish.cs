//Guillermo Pator, Daniel Miquel, Querubin Santana
//Sabater, Lopez, Rebollo
using System;

class Fish : Animated
{
    protected string type;
    protected string color;

    public Fish(string newType, string newColor)
    {
        if(DateTime.Now.Millisecond % 2 == 0)
        {
            image = "><>";
            x = 1;
            direction = 1;
        }
        else
        {
            image = "<><";
            x = 79;
            direction = -1;
        }   

        y = 20;
        type = newType;
        color = newColor;
        speed = 1;
    }

    public void ChangeDirection(int x)
    {
        if( x == 1)
        {
            image = "><>";
            direction = 1;
        }
        else if( x == 79)
        {
            image = "<><";
            direction = -1;
        }
    }

    public int GetX()
    {
        return x;
    }

    public void SetType(string newType)
    {
        type = newType;
    }

    public string GetType()
    {
        return type;
    }

    public void SetColor(string newColor)
    {
        color = newColor;
    }

    public string GetColor()
    {
        return color;
    }
}