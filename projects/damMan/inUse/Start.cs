using System;
// New version 20-04-18  Renata Pestana Ribeiro Square to do the Start but there is mistakes

class Start
{
    static string title = "Welcome To DamMan!";
    static int strSize = title.Length;
    static int widthSquare = title.Length + 10;
    static int hightSquare = 10;
    int positionSquareX = (Console.WindowWidth - widthSquare) / 2;
    int positionSquareY = (Console.WindowHeight - hightSquare) / 4;
    int textCentre = (widthSquare - strSize) / 2;

    public void Square()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.SetCursorPosition(positionSquareX, positionSquareY);
        for (int column = 0; column < widthSquare; column++)
        {
            Console.Write("_");
        }
        for (int row = 0; row < 2; row++)
        {
            positionSquareY++;
            Console.SetCursorPosition(positionSquareX, positionSquareY);
            Console.Write("|");

            Console.BackgroundColor = ConsoleColor.Gray;
            for (int column = 0; column < (widthSquare - 2); column++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("|");
            positionSquareY++;
            Console.SetCursorPosition(positionSquareX, positionSquareY);
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Gray;
            for (int column = 0; column < textCentre - 1; column++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(title);
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int column = 0; column < textCentre - 1; column++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("|");

        }
    }
        
}

