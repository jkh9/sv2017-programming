// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor

using System;

public class Sprite
{
    protected int x, y;
    protected string image;

    public Sprite(int x, int y, string image)
    {
        this.x = x;
        this.y = y;
        this.image = image;
    }

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(image);
    }
}