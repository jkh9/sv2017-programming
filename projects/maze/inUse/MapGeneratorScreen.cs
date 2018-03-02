/*
 - Created a MapGeneratorScreen to allow the user to create maps.
 - v0.10 - 28-Feb-2018 - Javier Saorín, Querubin Santana, Francisco Sabater.
 */

using System;
using System.IO;

class MapGeneratorScreen
{
    public string[,] GenerateMap()
    {
        const int MAP_HEIGHT = 4;
        const int MAP_WIDTH = 6;

        int xPos = 0;
        int yPos = 0;    

        string[,] map = new string[MAP_WIDTH, MAP_HEIGHT];

        for (int row = 0; row < MAP_HEIGHT; row++)
            for (int col = 0; col < MAP_WIDTH; col++)
                map[col, row] = "";

        // Top info bar.
         Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("ROOM WIDTH: " + MAP_WIDTH +
            "  ROOM HEIGHT: " + MAP_HEIGHT);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("-----------------------------");
        Console.ResetColor();

        // Bottom info bar.
        Console.SetCursorPosition(0, 18);
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("-----------------------------");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("POS X: " + xPos + "  POS Y: " + yPos + "       ");
        Console.ResetColor();

        // Draw rooms.
        Console.SetCursorPosition(0, 2);

        for (int row = 0; row < MAP_HEIGHT; row++)
        {
            for (int col = 0; col < MAP_WIDTH; col++)
            {
                bool up = false;
                bool down = false;
                bool left = false;
                bool right = false;

                if (map[col, row].Contains("U"))
                    up = true;
                else if (map[col, row].Contains("D"))
                    down = true;
                else if (map[col, row].Contains("L"))
                    left = true;
                else if (map[col, row].Contains("R"))
                    right = true;

                Console.SetCursorPosition(col * 5, row * 4);

                if (col != 0 && col != MAP_WIDTH &&
                    row != 0 && row != MAP_HEIGHT)
                {
                    if (up && down && left && right)
                    {
                        Console.WriteLine(" _ _ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("     ");
                        Console.WriteLine("|_ _|");
                    }
                    else if (up && down && left)
                    {
                        Console.WriteLine(" _ _ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("    |");
                        Console.WriteLine("|_ _|");
                    }
                    else if (up && down && right)
                    {
                        Console.WriteLine(" _ _ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|    ");
                        Console.WriteLine("|_ _|");
                    }
                    else if (up && down)
                    {
                        Console.WriteLine(" _ _ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|_ _|");
                    }
                    else if (up && left)
                    {
                        Console.WriteLine(" _ _ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("    |");
                        Console.WriteLine("|___|");
                    }
                    else if (up && right)
                    {
                        Console.WriteLine(" _ _ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|    ");
                        Console.WriteLine("|___|");
                    }
                    else if (left && right)
                    {
                        Console.WriteLine(" ___ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("     ");
                        Console.WriteLine("|___|");
                    }
                    else if (left && down)
                    {
                        Console.WriteLine(" ___ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("    |");
                        Console.WriteLine("|_ _|");
                    }
                    else if (up)
                    {
                        Console.WriteLine(" _ _ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|___|");
                    }
                    else if (down)
                    {
                        Console.WriteLine(" ___ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|_ _|");
                    }
                    else if (left)
                    {
                        Console.WriteLine(" ___ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("    |");
                        Console.WriteLine("|___|");
                    }
                    else if (right)
                    {
                        Console.WriteLine(" ___ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|    ");
                        Console.WriteLine("|___|");
                    }
                    else
                    {
                        Console.WriteLine(" ___ ");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|___|");
                    }
                }
            }
        }
        

        bool exit = false;
        do
        {
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.UpArrow)
            {
                if (yPos > 0)
                {
                    yPos--;
                }
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                if (yPos < MAP_HEIGHT)
                {
                    yPos++;
                }
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                if (xPos > 0)
                {
                    xPos--;
                }
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                if (xPos < MAP_WIDTH)
                {
                    xPos++;
                }
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                exit = true;
            }
            else
            {
                if (key.Key == ConsoleKey.W)
                {
                    if (map[xPos, yPos].Contains("W"))
                    {
                        map[xPos, yPos].Remove('W');
                    }
                    else
                    {
                        map[xPos, yPos] += 'U';
                    }
                }
                else if (key.Key == ConsoleKey.S)
                {
                    if (map[xPos, yPos].Contains("D"))
                    {
                        map[xPos, yPos].Remove('D');
                    }
                    else
                    {
                        map[xPos, yPos] += 'D';
                    }
                }
                else if (key.Key == ConsoleKey.D)
                {
                    if (map[xPos, yPos].Contains("R"))
                    {
                        map[xPos, yPos].Remove('R');
                    }
                    else
                    {
                        map[xPos, yPos] += 'R';
                    }
                }
                else if (key.Key == ConsoleKey.A)
                {
                    if (map[xPos, yPos].Contains("L"))
                    {
                        map[xPos, yPos].Remove('L');
                    }
                    else
                    {
                        map[xPos, yPos] += 'L';
                    }
                }
            }
        }
        while (!exit);

        return map;
    }
}
