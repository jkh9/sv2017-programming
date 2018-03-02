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