//V0.03 17-Ene-2018 
//  Daniel Miquel.Luis Martin-Montalvo, Jose Vilaplana, Javier Herreros, Lucía Navarro
//      Added new fish RapeFish

class RapeFish : Fish
{
    public RapeFish(int x, int y) : base(x, y)
    {
        image = "><>º";
        speed = 1;
    }

    public override void Move()
    {
        base.Move();
        if (speed > 0)
            image = "><>º";
        else
            image = "º<><";
    }
}
