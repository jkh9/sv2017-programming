// Javier Cases, Guillermo Pastor, Brandon Blasco
// V1: Approx 1.450 bytes
using System;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            GameScreen game = new GameScreen();
            game.Run();
        }
    }
}
//----
namespace Pong
{
    class GameScreen
    {
        protected int WIDTH;
        protected int HEIGT;

        public GameScreen()
        {
            WIDTH = Console.WindowWidth;
            HEIGT = Console.WindowHeight;
        }

        public void DrawMap()
        {
            string line = new string('-', WIDTH);
            Console.WriteLine(line);

            Console.WriteLine(line);
        }

        public void Scoreboard()
        {
            int scoreJ1 = 0;
            int scoreJ2 = 0;
            Console.SetCursorPosition(5, WIDTH / 2);
            Console.Write(scoreJ1);
            Console.WriteLine(scoreJ2);
        }

        public void Run()
        {
        }

    }
}
//----
namespace Pong
{
    abstract class AnimatedObject : GameScreen
    {
        protected short x, y;

        public AnimatedObject(short x, short y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw() { Console.SetCursorPosition(x, y); }
    }
}
//----
namespace Pong
{
    class Ball : AnimatedObject
    {
        public Ball(short x, short y) : base(x, y) { }
    }
}
