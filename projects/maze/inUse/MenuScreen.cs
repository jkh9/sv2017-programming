/*
 *  Maze Game
 * 
 *  V0.07 19-Dic-2017 Nacho: Almost empty skeleton + options
 */

using System;

public class MenuScreen
{
    public const int PLAY = 1;
    public const int CREDITS = 2;
    public const int QUIT = 0;

    protected int option;

    public MenuScreen()
    {
        option = 0;
    }

    public void Display()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Play!");
        Console.WriteLine("2. Credits");
        Console.WriteLine("0. Quit");
        
        option = Convert.ToInt32( Console.ReadLine() );
    }

    public int GetChosenOption()
    {
        return option;
    }

}

