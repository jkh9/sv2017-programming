//V0.03 17-Ene-2018 
//  Daniel Miquel.Luis Martin-Montalvo, Jose Vilaplana, Javier Herreros, Lucía Navarro
//      Added new fish RapeFish

// V0.05 02-Mar-2018 Nacho: 
//     Converted to a Graphic Sprite

class RapeFish : Fish
{
    public RapeFish(short x, short y)
        : base("images/pes4.png", "images/pes4_flip.png", 
            x, y, 128, 76, 10)
    {
    }
}
