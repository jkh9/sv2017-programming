using System;

class DamMan
{
    static void Main(string[] args)
    {
        Game myGame = new Game();
        myGame.Run();
    }
}

// ----------------

class Game
{
    public void Run()
    {
        Console.WriteLine("Running");
    }
}
