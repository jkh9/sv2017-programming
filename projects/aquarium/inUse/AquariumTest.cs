//Guillermo Pator, Daniel Miquel, Querubin Santana
//Sabater, Lopez, Rebollo
using System;

class AquariumTest
{
    static void Main()
    {
        Fish clownFish = new Fish("clownFish", "Red");
        while(true)
        {
            Console.Clear();
            clownFish.Draw();
            clownFish.ChangeDirection(clownFish.GetX());
            clownFish.Move();
        }
    }
}
