// V0.01 20-Dic-2017 
// Guillermo Pator, Daniel Miquel, Querubin Santana
// Sabater, Lopez, Rebollo

// V0.02 16-Ene-2018 Nacho: 
//     Added a bubble
//     Pause after each frame

// v0.04 28-feb-2018
//     Ángel Rebollo Berná, Almudena Lopez Sanchez, Daniel Miquel Sirera
//     Added Support for Sdl libraries
//     Added class Hardware and image
//     Created constructor on Hardware and Image clases
//     Included Sprites for all Fishes

// V0.05 02-Mar-2018, Nacho: Really uses Tao.SDL

using System;
using System.Threading;

class AquariumTest
{
    static void Main()
    {
        // Initialization
        bool fullScreen = false;
        Hardware hard = new Hardware(800, 600, 24, fullScreen);

        // Creation of elements
        Image background = new Image("Images/back.jpg", 800, 600);
        Random r = new Random();
        AnimatedSprite[] aniSpr = new AnimatedSprite[10];

        short y = (short)r.Next(0, 700);
        short x = (short)r.Next(10, 500);
        aniSpr[0] = new GoldFish(x, y);
        y = (short) r.Next(0, 700);
        x = (short) r.Next(10, 500);
        aniSpr[1] = new GoldFish(x, y);
        y = (short) r.Next(0, 700);
        x = (short) r.Next(10, 500);
        aniSpr[2] = new RapeFish(x, y);
        y = (short) r.Next(0, 700);
        x = (short) r.Next(10, 500);
        aniSpr[3] = new SwordFish(x, y);
        y = (short) r.Next(0, 700);
        x = (short) r.Next(10, 500);
        aniSpr[4] = new SharkFish(x, y);

        for (int i = 5; i < 10; i++)
        {
            aniSpr[i] = new Bubble(
                (short) r.Next(0, 700),
                (short) r.Next(0, 500));
        }

        bool finished = false;

        while (! finished)
        {
            // Drawing elements
            hard.ClearScreen();
            hard.DrawImage(background);
            for (int i = 0; i < 10; i++)
            {
                aniSpr[i].Draw(hard);
            }
            hard.UpdateScreen();

            // Moving elements to ttheir next position
            for (int i = 0; i < 10; i++)
            {
                aniSpr[i].Move();
            }

            // Checking input devices
            if (hard.IsKeyPressed(Hardware.KEY_ESC))
                finished = true;

            // And pausing after each frame
            Thread.Sleep(100); // 100 ms pause
        }
    }
}
