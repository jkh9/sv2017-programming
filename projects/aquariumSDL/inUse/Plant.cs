// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Renamed from Animated to AnimatedSprite
//     Added constructor

// V0.05 02-Mar-2018 Nacho: 
//     Converted to a Graphic Sprite

class Plant : StaticSprite
{
    public Plant(short x, short y)
        : base("images/algas1.png", x, y, 118, 128)
    {
    }
}