// 
// DamMan
// Player: PacMan, used by the player  
//

// Versions:
// V0.01 13-Dic-2017 Nacho: Almost empty skeleton
// V0.03 07-Ene-2018 Nacho: Player can move right
// v0.04 17-Ene-2018 Luis Sellés, Brandon Blasco, César Martinez, Tania Pigem:
//            Player can move in four directions

public class Player : Sprite
{
    // Associations

    // public Game  myGame;

    // Operations

    public void MoveRight()
    {
        // Note: we should check if we can move
        x++;
    }

    public void MoveLeft()
    {
        x--;
    }

    public void MoveUp()
    {
        y--;// TO DO
    }

    public void MoveDown()
    {
        y++;// TO DO
    }
} /* end class Player */