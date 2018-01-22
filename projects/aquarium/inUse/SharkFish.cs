//V0.03 17-Ene-2018 
//  Daniel Miquel.Luis Martin-Montalvo, Jose Vilaplana, Javier Herreros, Lucía Navarro
//      Added new fish SharkFish

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