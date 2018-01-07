
/*
 *  Maze Game
 * 
 *  V0.07 19-Dic-2017 Nacho: Almost empty skeleton
 *  V0.08 20-Dic-2017 Lucia, HP, Daniel: Some text...
 */
 
 using System;

public class CreditsScreen
{

    public void Display()
    {
        int i = 2;
        Console.Clear();
        Console.SetCursorPosition(20, 0);
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("MAZE");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(14, i);
        Console.WriteLine("·Creator: Fifteen");
        i++;
        Console.SetCursorPosition(14, i);
        Console.WriteLine("·Designer: Sahrien");
        i++;
        Console.SetCursorPosition(14, i);
        Console.WriteLine("·Programmer: HP96");
        i++;
        Console.SetCursorPosition(14, i);
        Console.WriteLine("·Music: There is no music yet");
        i++;
        Console.SetCursorPosition(14, i);
        Console.WriteLine("·No human being has suffered");
        i++;
        Console.SetCursorPosition(14, i);
        Console.WriteLine("     physical damage with the");
        i++;
        Console.SetCursorPosition(14, i);
        Console.WriteLine("     creation of this project.");
        i++;
        Console.SetCursorPosition(14, i);
        Console.WriteLine("·All the human beings who have");
        i++;
        Console.SetCursorPosition(14, i);
        Console.WriteLine("     participated in this project have ");
        i++;
        Console.SetCursorPosition(14, i);
        Console.WriteLine("     suffered psychological damage");
        
        Console.ResetColor();
        Console.ReadLine();
        Console.Clear();
    }

}
