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
class SharkFish : Fish
{
    public SharkFish(int x, int y) : base(x, y)
    {
        image = "><v>";
        speed = 2;
    }

    public override void Move()
    {
        base.Move();
        if (speed > 0)
            image = "><v>";
        else
            image = "<v><";
    }
}