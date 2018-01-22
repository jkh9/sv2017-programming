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
        Random r = new Random();
        AnimatedSprite[] aniSpr = new AnimatedSprite[10];

        int hei = r.Next(0, 25);
        int wit = r.Next(3, 78);
        aniSpr[0] = new GoldFish(wit, hei);
        hei = r.Next(0, 25);
        wit = r.Next(3, 78);
        aniSpr[1] = new Fish(wit, hei);
        hei = r.Next(0, 25);
        wit = r.Next(3, 78);
        aniSpr[2] = new RapeFish(wit, hei);
        hei = r.Next(0, 25);
        wit = r.Next(3, 78);
        aniSpr[3] = new SwordFish(wit, hei);
        hei = r.Next(0, 25);
        wit = r.Next(3, 78);
        aniSpr[4] = new SharkFish(wit, hei);

        for (int i = 5; i < 10; i++)
        {
            aniSpr[i] = new Bubble(r.Next(0, 81), r.Next(0, 20));
        }

        while (true)
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                aniSpr[i].Draw();
            }
            for (int i = 0; i < 10; i++)
            {
                aniSpr[i].Move();
            }

            Thread.Sleep(100); // 100 ms pause
        }
    }
}
