// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor

using System;
// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Added a bubble
//     Pause after each frame

//v0.03 28-feb-2018
//     Ángel Rebollo Berná, Almudena Lopez Sanchez, Daniel Miquel Sirera
//     Added Support for Sdl libraries
//     Added class Hardware and image
//     Created constructor on Hardware and Image clases
//     Included Sprites for all Fishes
using Tao.Sdl;


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

    public void MoveTo(short X, short Y)
    {
        x = X;
        y = Y;
    }

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(image);
    }
}
