
/*
 *  Maze Game
 * 
 *  V0.07 19-Dic-2017 Nacho: Almost empty skeleton
 *  V0.08 20-Dic-2017 Lucia, HP, Daniel: Some text...
 *  V0.12 20-Abr-2018 Daniel,Javier,Gonzalo: credits are read from file
 */

using System;
using System.IO;


public class CreditsScreen
{
    public void Display()
    {
        int widthText = Console.WindowWidth - 20;
        int posX = 5, posY = 10;

        StreamReader credits = File.OpenText("CreditScreenText.txt");
        string line;
        Console.Clear();
        do
        {
            line = credits.ReadLine();
            if (line != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(posX, posY);
                Console.WriteLine(line);
                posY++;
            }
        } while (line != null);
        Console.ReadLine();

    }
}