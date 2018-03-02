// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor
//     Removed "direction": speed can be negative
//     Updated Move

// V0.05 02-Mar-2018 Nacho: 
//     Converted to a Graphic Sprite

class AnimatedSprite : Sprite
{
    protected short speed;

    public AnimatedSprite(string filenameRight, string filenameLeft,
            short x, short y, short width, short height, short speed)
        : base(filenameRight, filenameLeft, x, y, width, height)
    {
        this.speed = speed;
    }

    public virtual void Move()
    {
        // TO DO: screen width should not be a magic number
        X += speed;
        if ((X < 2) || (X > 800 - width))
        {
            speed = (short)-speed;
            lookingLeft = ! lookingLeft;
        }
    }
}
