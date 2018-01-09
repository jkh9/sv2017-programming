//Guillermo Pator, Daniel Miquel, Querubin Santana
//Sabater, Lopez, Rebollo
using System;

class Sprite
{
    protected int x, y;
    protected string image;

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(image);
    }
}