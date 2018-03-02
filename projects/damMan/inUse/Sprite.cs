// 
// DamMan
// Sprite: The base for the moving figures
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// v0.02 14-dic-2017 Angel, Pedro, Saorin. Constructors getters and setters
// v0.04 17-Ene-2018 Luis Sellés, Brandon Blasco, César Martinez, Tania Pigem:
//          Drawing ghosts 
// V0.05 28-Feb-2018 Marcos, Jose, Moisés

using System;

public class Sprite
{
    // Attributes

    protected int x;
    protected int y;
    protected bool visible;

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

    public virtual void Display()
    {
        //Implemented in subclasses
    }

    public virtual void ClearCharacter()
    {
        //Implemented in subclasses
    }

    public void MoveTo(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
} /* end class Sprite */
