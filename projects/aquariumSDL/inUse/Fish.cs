// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor
//     Updated Move
//     Removed unnecessary extra methods

// V0.05 02-Mar-2018 Nacho: 
//     Converted to a Graphic Sprite

abstract class Fish : AnimatedSprite
{

    public Fish(string filenameRight, string filenameLeft,
            short x, short y, short width, short height, short speed)
        : base(filenameRight, filenameLeft, x, y, width, height, speed)
    {
    }

    public override void Move()
    {
        base.Move();
    }
}