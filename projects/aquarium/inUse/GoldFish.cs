﻿//V0.03 17-Ene-2018 
//  Daniel Miquel.Luis Martin-Montalvo, Jose Vilaplana, Javier Herreros, Lucía Navarro
//      Added new fish GoldFish

class GoldFish : Fish
{
    public GoldFish(int x, int y)
        : base(x, y)
    {
        image = "><$";
        speed = 1;
    }

    public override void Move()
    {
        base.Move();
        if (speed > 0)
            image = "><$";
        else
            image = "$><";
    }
}