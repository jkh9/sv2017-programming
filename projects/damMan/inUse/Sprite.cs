// 
// DamMan
// Sprite: The base for the moving figures
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// v0.02 14-dic-2017 Angel, Pedro, Saorin. Constructors getters and setters

using System;

public class Sprite
{
    // Attributes

    protected int x;
    protected int y;
    protected bool visible;
    protected char symbol = 'o';

    public Sprite(int newX, int newY, bool newVisible)
    {
        x = newX;
        y = newY;
        visible = newVisible;
    }

    public Sprite()
    {
        x = 1;
        y = 1;
        visible = true;
    }

    public void SetX(int newX)
    {
        x = newX;
    }

    public void SetY(int newY)
    {
        y = newY;
    }

    public void SetVisible(bool newVisible)
    {
        visible = newVisible;
    }

    public bool GetVisible()
    {
        return visible;
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }

    // Operations

    public void Move()
    {
        // To be implemented in subclasses
    }

    public void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }

    public void MoveTo(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
} /* end class Sprite */
