// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor, Move

class Bubble : AnimatedSprite
{
    public Bubble(int x, int y)
        : base(x, y, "o", -1)
    {
    }

    public override void Move()
    {
        y += speed;
        if (y < 1)
            y = 22;
    }
}