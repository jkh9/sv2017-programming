using System;

public class Pong
{
    public static void Main()
    {
        // Variable to exit
        bool exitGame = false;

        // Variable to reset
        bool points = false;

        // Variables to store ball's coordinates
        int ballX = 40, ballY = 11, ballYDirection = 0, ballXDirection = 1;

        // Variables to store player's X position
        const byte player1X = 4, player2X = 76;

        // Variables to store player's Y position
        byte player1Y = 1, player2Y = 1;

        // Variables to store points
        byte pointsA = 0, pointsB = 0;

        // Constant to define bar width
        const int BAR_HEIGHT = 3;

        ConsoleKeyInfo key;

        // Print panel points

        Console.SetCursorPosition(40, 0);
        Console.WriteLine(pointsA + " - " + pointsB);

        // Print panels game

        for (int i = 0; i < 80; i++)
        {
            Console.SetCursorPosition(i, 0);
            if (i < 39 || i > 45)
                Console.Write("-");
        }
        Console.SetCursorPosition(1, 24);
        for (int i = 0; i < 80; i++)
            Console.Write("-");
        Console.SetCursorPosition(0, 0);
        for (int i = 0; i <= 24; i++)
            Console.WriteLine("|");
        for (int i = 0; i <= 24; i++)
        {
            Console.SetCursorPosition(80, i);
            Console.Write("|");
        }

        // Game Loop
        while (!exitGame)
        {
            // 1 Draw Players

            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < BAR_HEIGHT; i++)
            {
                Console.SetCursorPosition(player1X, player1Y + i);
                Console.WriteLine(" ");
            }

            for (int i = 0; i < BAR_HEIGHT; i++)
            {
                Console.SetCursorPosition(player2X, player2Y + i);
                Console.Write(" ");
            }
            Console.ResetColor();

            // 2 Draw Ball

            Console.SetCursorPosition(ballX, ballY);
            Console.WriteLine("O");

            // 3 Pause

            Console.SetCursorPosition(81, 26);
            System.Threading.Thread.Sleep(100);

            // 4 Read input and calculate player's new position

            if (Console.KeyAvailable)
            {
                do
                {
                    key = Console.ReadKey(false);
                    Console.ResetColor();
                    for (int i = 0; i < BAR_HEIGHT; i++)
                    {
                        Console.SetCursorPosition(player1X, player1Y + i);
                        Console.WriteLine(" ");
                    }

                    for (int i = 0; i < BAR_HEIGHT; i++)
                    {
                        Console.SetCursorPosition(player2X, player2Y + i);
                        Console.Write(" ");
                    }

                    if (key.Key == ConsoleKey.UpArrow && player1Y > 1)
                        player1Y--;
                    if (key.Key == ConsoleKey.DownArrow && player1Y + BAR_HEIGHT < 24)
                        player1Y++;
                    if (key.Key == ConsoleKey.LeftArrow && player2Y > 1)
                        player2Y--;
                    if (key.Key == ConsoleKey.RightArrow && player2Y + BAR_HEIGHT < 24)
                        player2Y++;
                    if (key.Key == ConsoleKey.Escape)
                        exitGame = true;
                }
                while (Console.KeyAvailable);
            }

            // 5 Move ball

            Console.ResetColor();
            Console.SetCursorPosition(ballX, ballY);
            Console.Write(" ");

            // 5 Check collisions and update game state

            for (int positionY = 0; positionY < BAR_HEIGHT; positionY++)
            {
                if (ballX == player1X && ballY == player1Y + positionY)
                {
                    ballYDirection = positionY - 1;
                    ballXDirection = -ballXDirection;
                }
                if (ballX == player2X && ballY == player2Y + positionY)
                {
                    ballYDirection = positionY - 1;
                    ballXDirection = -ballXDirection;
                }
            }

            if (ballX <= 0)
            {
                pointsB++;
                Console.SetCursorPosition(40, 0);
                Console.WriteLine(pointsB);
                Console.SetCursorPosition(0, ballY);
                Console.Write("|");
                points = true;
            }

            if (ballX >= 78)
            {
                pointsA++;
                Console.SetCursorPosition(44, 0);
                Console.WriteLine(pointsA);
                Console.SetCursorPosition(0, ballY);
                Console.Write("|");
                points = true;
            }

            if (points)
            {
                ballX = 40;
                ballY = 12;
                ballXDirection = -ballXDirection;
                ballYDirection = 0;
            }

            if (ballY == 0 || ballY == 24)
            {
                Console.SetCursorPosition(ballX, ballY);
                Console.Write("-");
                ballYDirection = -ballYDirection;
            }

            ballY += ballYDirection;
            ballX += ballXDirection;
            points = false;
        }

        Console.SetCursorPosition(20, 12);
    }
}
