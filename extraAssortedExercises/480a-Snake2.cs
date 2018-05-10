// Santana, Saorín

using System;
using System.Collections.Generic;

class SnakeGame
{
    static void Main()
    {
        GameScreen.Run();
    }
}
// ------------

class GameScreen
{
    public static void Follow(List<Part> snake, int posfollow)
    {
        if (posfollow != snake.Count - 1)
        {
            snake[posfollow + 1].XPos = snake[posfollow].XPos;
            snake[posfollow + 1].YPos = snake[posfollow].YPos;

            Follow(snake, posfollow += 1);
        }
    }

    public static void Move(List<Part> snake)
    {
        for (int i = 0; i < snake.Count; i++)
        {
            Console.SetCursorPosition(snake[i].XPos, snake[i].YPos);
            Console.Write(i == 0 ? "O" : "o");
        }
    }
    
    public struct Food
    {
        public char sprite;
        public bool eaten;
        public int x;
        public int y;
    }

    public static Food PutRandomFood()
    {
        Food f;
        Random rdn = new Random();     
        f.x = rdn.Next(0, 80);
        f.y = rdn.Next(0, 24);
        f.sprite = 'f';
        f.eaten = false;
        return f;
    }

    public static void Run()
    {
        bool isAlive = true;
        List<Part> snake = new List<Part>();
        Food food = PutRandomFood();
        
        snake.Add(new Part(40, 12));
        snake.Add(new Part(41, 12));
        snake.Add(new Part(42, 12));

        Move(snake);

        int direction = 3;
   
        do
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    direction = 0;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    direction = 1;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    direction = 2;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    direction = 3;
                }
            }           

            switch (direction)
            {
                case 0:
                    snake[0].YPos = --snake[0].YPos;
                    break;
                case 1:
                    snake[0].XPos = ++snake[0].XPos;
                    break;
                case 2:
                    snake[0].YPos = ++snake[0].YPos;
                    break;
                case 3:
                    snake[0].XPos = --snake[0].XPos;
                    break;
                default:          
                    break;
            }

            if (snake[0].XPos <= 0)
                snake[0].XPos = 79;
            else if (snake[0].XPos >= 80)
                snake[0].XPos = 0;

            if (snake[0].YPos <= 0)
                snake[0].YPos = 24;
            else if (snake[0].YPos >= 24)
                snake[0].YPos = 0;

            if (snake[0].XPos == food.x &&
                snake[0].YPos == food.y)
            {
                snake.Add(new Part(snake[snake.Count - 1].XPos,
                    snake[snake.Count - 1].YPos));
                food = PutRandomFood();
            }

            Console.Clear();
            Console.SetCursorPosition(food.x, food.y);
            Console.WriteLine(food.sprite);
            Move(snake);
            Follow(snake, 0);

            Console.SetCursorPosition(0, 0);
            System.Threading.Thread.Sleep(250);
        }
        while (isAlive);
    }
}

// ------------

class Part
{
    public int XPos{ get; set; }
    public int YPos { get; set; }

    public Part(int xPos, int yPos)
    {
        XPos = xPos;
        YPos = yPos;
    }
}
