// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor

// V0.05 02-Mar-2018 Nacho: 
//     Converted to a Graphic Sprite, loosely based on Gauntlet skeleton

using System.Collections.Generic;

class Sprite
{
    public short X { get; set; }
    public short Y { get; set; }
    public short width { get; set; }
    public short height { get; set; }

    protected Image imageLeft, imageRight;
    protected bool lookingLeft = true;

    public Sprite(string filenameRight, string filenameLeft,
        short x, short y,
        short width, short height)
    {
        X = x;
        Y = y;
        imageRight = new Image(filenameRight, width, height);
        imageLeft = new Image(filenameLeft, width, height);
    }

    public void MoveTo(short x, short y)
    {
        X = x;
        Y = y;
    }

    public bool CollidesWith(Sprite sp)
    {
        return (X + width > sp.X && X < sp.X + width &&
                Y + height > sp.Y && Y < sp.Y + height);
    }

    public bool CollidesWith(List<Sprite> sprites)
    {
        foreach (Sprite sp in sprites)
            if (this.CollidesWith(sp))
                return true;
        return false;
    }

    public void Draw(Hardware h)
    {
        imageLeft.MoveTo(X, Y);
        imageRight.MoveTo(X, Y);
        if (lookingLeft)
            h.DrawImage(imageLeft);
        else
            h.DrawImage(imageRight);

    }
}

