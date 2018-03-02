//V0.03 17-Ene-2018 
//  Daniel Miquel.Luis Martin-Montalvo, Jose Vilaplana, Javier Herreros, Lucía Navarro
//      Added new fish RapeFish

// V0.05 02-Mar-2018 Nacho: 
//     Converted to a Graphic Sprite

class SharkFish : Fish
{
    public SharkFish(short x, short y)
        : base("images/pes3_flip.png", "images/pes3.png", 
            x, y, 128, 126, 6)
    {
    }
}
