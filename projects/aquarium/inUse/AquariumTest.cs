// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Added a bubble
//     Pause after each frame

using System;
using System.Threading;

class AquariumTest
{
    static void Main()
    {
        Fish clownFish = new Fish(5, 10);
        Bubble b = new Bubble(10, 20);
        while(true)
        {
            Console.Clear();
            clownFish.Draw();
            b.Draw();

            b.Move();
            clownFish.Move();

            Thread.Sleep(100); // 100 ms pause
        }
    }
}
