// 
// DamMan
// Game: Game logic
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.02 14-Dic-2017 Gonzalo, Victor, Miguel: Constructor, player movement, calling 
//         other functions.
// V0.03 07-Ene-2018 Nacho: Level is displayed. Pause after each frame

using System;

public class Game
{
    // Attributes

    private int score;

    // Associations

    private OrangeGhost myOrangeGhost;
    private Player myPlayer;
    private Level myLevel;

    // Constructor

    public Game()
    {
        myOrangeGhost = new OrangeGhost();
        myPlayer = new Player();
        myLevel = new Level();
    }

    // Operations

    public void Run()
    {
        bool gameFinished = false;
        score = 0;
        do
        {
            checkInput();
            moveElements();
            checkCollisions();
            drawElements();
            pauseTillNextFrame();
        }
        while (!gameFinished);
    }


    // --- Checking keyboard, mouse and joystick -----
    private void checkInput()
    {
        ConsoleKeyInfo key;
        if (Console.KeyAvailable)
        {
            do
            {
                key = Console.ReadKey();
            } while (Console.KeyAvailable);

            if (key.Key == ConsoleKey.LeftArrow)
            {
                myPlayer.MoveLeft();
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                myPlayer.MoveRight();
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                myPlayer.MoveUp();
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                myPlayer.MoveDown();
            }
        }
    }


    // --- Animating enemies and other "self moving" objects -----
    private void moveElements()
    {
        myPlayer.Move();
        myOrangeGhost.Move();
    }


    // --- Checking collisons with enemies and background ---
    private void checkCollisions()
    {
        // TO DO
    }


    // --- Drawing all the visible elements ---
    private void drawElements()
    {
        Console.Clear();
        myLevel.Display();
        myPlayer.Display();
        myOrangeGhost.Display();
    }


    // --- Pause afer each frame (20 ms, for a speed of 50 fps) -----
    private void pauseTillNextFrame()
    {
        // 50 ms pause => 20 fps
        System.Threading.Thread.Sleep(50);
    }

} /* end class Game */ 