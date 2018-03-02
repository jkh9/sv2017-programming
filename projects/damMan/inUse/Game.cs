// 
// DamMan
// Game: Game logic
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.02 14-Dic-2017 Gonzalo, Victor, Miguel: Constructor, player movement, calling 
//         other functions.
// V0.03 07-Ene-2018 Nacho: Level is displayed. Pause after each frame
// V0.05 28-Feb-2018 Marcos, Jose, Moisés: Collisions checked

using System;

public class Game
{
    // Attributes

    private int score;

    // Associations

    //Array wich contains the ghosts
    private Ghost[] myGhosts = new Ghost[4];
    private Player myPlayer;
    private Level myLevel;

    // Constructor

    public Game()
    {
        //Implementing the 4 type of ghost
        myGhosts[0] = new OrangeGhost();
        myGhosts[1] = new BlueGhost();
        myGhosts[2] = new RedGhost();
        myGhosts[3] = new PinkGhost();
        //Implementing the player
        myPlayer = new Player();
        //Implementing the level
        myLevel = new Level();
    }

    // Operations

    public void Run()
    {
        bool gameFinished = false;
        score = 0;

        myLevel.Display();
        do
        {
            checkInput();
            moveElements();
            checkCollisions();
            drawElements();
            pauseTillNextFrame();
            clearSprites();
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
                key = Console.ReadKey(true);
            } while (Console.KeyAvailable);

            if (key.Key == ConsoleKey.LeftArrow &&
                myLevel.CanMoveTo(myPlayer.GetX() - 1, myPlayer.GetY()))
            {
                myPlayer.MoveLeft();
            }
            else if (key.Key == ConsoleKey.RightArrow &&
                myLevel.CanMoveTo(myPlayer.GetX() + 1, myPlayer.GetY()))
            {
                myPlayer.MoveRight();
            }
            else if (key.Key == ConsoleKey.UpArrow &&
                myLevel.CanMoveTo(myPlayer.GetX(), myPlayer.GetY() - 1))
            {
                myPlayer.MoveUp();
            }
            else if (key.Key == ConsoleKey.DownArrow &&
                myLevel.CanMoveTo(myPlayer.GetX(), myPlayer.GetY() + 1))
            {
                myPlayer.MoveDown();
            }
        }
    }


    // --- Animating enemies and other "self moving" objects -----
    private void moveElements()
    {
        //Move the 4 ghosts
        for (int i = 0; i < 4; i++)
        {
            myGhosts[i].Move(myLevel);
        }
    }


    // --- Checking collisons with enemies and background ---
    private void checkCollisions()
    {
        // TO DO
    }


    // --- Drawing all the visible elements ---
    private void drawElements()
    {
        //Draw the 4 ghosts and the player
        myPlayer.Display();
        for (int i = 0; i < 4; i++)
        {
            myGhosts[i].Display();
        }
    }


    // --- Pause afer each frame (20 ms, for a speed of 50 fps) -----
    private void pauseTillNextFrame()
    {
        // 50 ms pause => 20 fps
        System.Threading.Thread.Sleep(100);
    }

    //Clear of the sprites before writing them again
    private void clearSprites()
    {
        myPlayer.ClearCharacter();

        for (int i = 0; i < 4; i++)
        {
            myGhosts[i].ClearCharacter();
        }
    }

} /* end class Game */ 