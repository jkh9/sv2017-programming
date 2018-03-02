//V0.03 17-Ene-2018 
//  Daniel Miquel.Luis Martin-Montalvo, Jose Vilaplana, Javier Herreros, Lucía Navarro
//      Added new fish RapeFish

// V0.05 02-Mar-2018 Nacho: 
//     Converted to a Graphic Sprite

class SwordFish : Fish
{
    public SwordFish(short x, short y)
        : base("images/pes2.png", "images/pes2_flip.png", x, y, 
            128, 88, 8)
    {
    }
}
