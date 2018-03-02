//V0.03 17-Ene-2018 
//  Daniel Miquel.Luis Martin-Montalvo, Jose Vilaplana, Javier Herreros, Lucía Navarro
//      Added new fish GoldFish

// V0.05 02-Mar-2018 Nacho: 
//     Converted to a Graphic Sprite

class GoldFish : Fish
{
    public GoldFish(short x, short y)
        : base("images/pes5_flip.png", "images/pes5.png", x, y, 128, 106, 10)
    {
    }
}