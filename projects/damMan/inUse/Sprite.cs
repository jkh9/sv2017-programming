// 
// DamMan
// Sprite: The base for the moving figures
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// v0.02 14-dic-2017 Angel, Pedro, Saorin. Constructors getters and setters
// v0.04 17-Ene-2018 Luis Sellés, Brandon Blasco, César Martinez, Tania Pigem:
//          Drawing ghosts 

using System;

public class Sprite
{
    // Attributes

    protected int x;
    protected int y;
    protected bool visible;
    protected char symbol = 'o';
    protected char ghost = 'n';

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

        Console.SetCursorPosition(3,5);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(ghost);

        Console.SetCursorPosition(10, 5);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(ghost);

        Console.SetCursorPosition(6, 10);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(ghost);

        Console.SetCursorPosition(5, 20);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(ghost);
    }

    public void MoveTo(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
} /* end class Sprite */
