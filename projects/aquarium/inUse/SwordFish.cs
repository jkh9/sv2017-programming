//V0.03 17-Ene-2018 
//  Daniel Miquel.Luis Martin-Montalvo, Jose Vilaplana, Javier Herreros, Lucía Navarro
//      Added new fish SwordFish

class SwordFish : Fish
{
    public SwordFish(int x, int y) : base(x, y)
    {
    image = "><>-";
    speed = -1;
}

public override void Move()
{
    base.Move();
    if (speed > 0)
        image = "><>-";
    else
        image = "-<><";
}
}