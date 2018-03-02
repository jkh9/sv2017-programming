// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Added a bubble
//     Pause after each frame

//v0.03 28-feb-2018
//     Ángel Rebollo Berná, Almudena Lopez Sanchez, Daniel Miquel Sirera
//     Added Support for Sdl libraries
//     Added class Hardware and image
//     Created constructor on Hardware and Image clases
//     Included Sprites for all Fishes
using System;
using Tao.Sdl;
using System.Threading;

class AquariumTest
{
    static void Main()
    {
        Image SpriteSheet = new Image("Images/back.jpg", 800, 600);
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
