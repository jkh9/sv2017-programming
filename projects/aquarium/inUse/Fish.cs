// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor
//     Updated Move
//     Removed unnecessary extra methods

using System;

class Fish : AnimatedSprite
{
    protected string type;
    protected string color;

    public Fish(int x, int y)
        : base(x, y, "><>", 1)
    {
    }

    public override void Move()
    {
        base.Move();
        if (speed > 0)
            image = "><>";
        else
            image = "<><";
    }

}