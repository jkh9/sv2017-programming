/*
 *  Maze Game
 * 
 *  V0.07 19-Dic-2017 Nacho: Empty skeleton
 *  V0.08 20-Dic-2017 Javier Saorín, Raúl Gogna, Miguel Pastor: Display rooms.
 */

using System;

public class RoomViewer
{
    enum orientations { NORTH, EAST, SOUTH, WEST };

    public void Display(int actualOrientation, string[,] map, int x, int y)
    {
        if (actualOrientation == (byte)orientations.SOUTH &&
            map[y, x].Contains("D"))
            DisplayDoor();
        else if (actualOrientation == (byte)orientations.WEST &&
            map[y, x].Contains("L"))
            DisplayDoor();
        else if (actualOrientation == (byte)orientations.NORTH &&
            map[y, x].Contains("U"))
            DisplayDoor();
        else if (actualOrientation == (byte)orientations.EAST &&
            map[y, x].Contains("R"))
            DisplayDoor();
        else
            DisplayWall();
    }
    
    public void DisplayDoor()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine(" \\                   /");
        Console.WriteLine("  \\                 /");
        Console.WriteLine("   -----------------");
        Console.WriteLine("  |                 |");
        Console.WriteLine("  |                 |");
        Console.WriteLine("  |        ___      |");
        Console.WriteLine("  |       |   |     |");
        Console.WriteLine("  |       |   |     |");
        Console.WriteLine("   -----------------");
        Console.WriteLine("  /                 \\");
        Console.WriteLine(" /                   \\");
        Console.WriteLine();
        Console.ResetColor();
    }

    public void DisplayWall()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine(" \\                   /");
        Console.WriteLine("  \\                 /");
        Console.WriteLine("   -----------------");
        Console.WriteLine("  |                 |");
        Console.WriteLine("  |                 |");
        Console.WriteLine("  |                 |");
        Console.WriteLine("  |                 |");
        Console.WriteLine("  |                 |");
        Console.WriteLine("   -----------------");
        Console.WriteLine("  /                 \\");
        Console.WriteLine(" /                   \\");
        Console.WriteLine();
        Console.ResetColor();
    }
}
