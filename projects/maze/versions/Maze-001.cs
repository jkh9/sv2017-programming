/*
 *  Maze Game
 * 
 *  Francisco Sabater Villora, 2017
 * 
 *  V0.01 20-Sep-2017 Main menu
 */
 
using System;

public class Maze
{
    public static void Main()
    {
        int option;
        
        Console.WriteLine("1.- New Game.");
        Console.WriteLine("2.- Load Game.");
        Console.WriteLine("3.- Help.");
        Console.WriteLine("4.- Credits.");
        Console.WriteLine("5.- Options.");
        Console.WriteLine("0.- Exit.");
        Console.Write("Select an option: ");
        option = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Option not available... yet");
    }
}
