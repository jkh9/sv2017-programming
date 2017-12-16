// 
// DamMan
// Sprite: The base for the moving figures
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton

using System;

public class Sprite
{
    // Attributes

    private int x;
    private int y;
    private bool visible;
    private char symbol = 'o';

    // Operations

    public  void Move()
    {
        // To be implemented in subclasses
    }

    public  void Display()
    {
        Console.SetCursorPosition(x,y);
        Console.Write(symbol);
    }

    public  void MoveTo(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
} /* end class Sprite */
