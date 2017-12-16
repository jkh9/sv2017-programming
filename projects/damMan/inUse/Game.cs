// 
// DamMan
// Game: Game logic
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton

/// <summary>
///  A class that represents ...
/// 
///  @see OtherClasses
///  @author your_name_here
/// </summary>
public class Game
{
    // Attributes

    private int score;

    // Associations

    private OrangeGhost myOrangeGhost;
    private Player myPlayer;
    private Level myLevel;

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
        // TO DO
    }


    // --- Animating enemies and other "self moving" objects -----
    private void moveElements()
    {
        // TO DO
    }


    // --- Checking collisons with enemies and background ---
    private void checkCollisions()
    {
        // TO DO
    }


    // --- Drawing all the visible elements ---
    private void drawElements()
    {
        // TO DO
    }


    // --- Pause afer each frame (20 ms, for a speed of 50 fps) -----
    private void pauseTillNextFrame()
    {
        // TO DO
    }

} /* end class Game */ 