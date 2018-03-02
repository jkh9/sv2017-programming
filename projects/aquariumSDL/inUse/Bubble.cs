// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor, Move

// V0.05 02-Mar-2018 Nacho: 
//     Converted to a Graphic Sprite

class Bubble : AnimatedSprite
{
    public Bubble(short x, short y)
        : base("images/bubble.png", "images/bubble.png", x, y, 30, 30, -5)
    {
    }

    public override void Move()
    {
        // TO DO: screen width should not be a magic number
        Y += speed;
        if (Y < 1)
            Y = 600;
    }
}