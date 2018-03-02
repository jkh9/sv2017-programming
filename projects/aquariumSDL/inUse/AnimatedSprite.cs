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
