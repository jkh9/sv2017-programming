// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor
//     Removed "direction": speed can be negative
//     Updated Move

class AnimatedSprite : Sprite
{
    protected int speed;

    public AnimatedSprite(int x, int y, string image, int speed)
        : base(x, y, image)
    {
        this.speed = speed;
    }

    public virtual void Move()
    {
        x += speed;
        if ((x < 2) || (x > 78 - image.Length))
            speed = -speed;
    }
}
