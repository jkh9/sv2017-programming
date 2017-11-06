//Almudena Lopez Sanchez, Francisco Sabater Villora, Marcos Cervantes Matamoros
//Three in a row
using System;
public class ThreeInARow
{
    public static void Main()
    {
        const int ROW = 3;
        const int COLUMNS = 3;
        char[,] board = new char [ROW,COLUMNS];
        
        Console.WriteLine("Enter row position)");
        byte row = Convert.ToByte(Console.ReadLine());  
        Console.WriteLine("Enter column position)");
        byte column = Convert.ToByte(Console.ReadLine());
        
        board [row,column] = 'x'; 
        Console.WriteLine(" ___________");
        Console.WriteLine("| "+ board[0,0]+" | "+board[0,1]+" | "+board[0,2]+" |");
        Console.WriteLine("|___|___|___|");
        Console.WriteLine("| "+board[1,0]+" | "+board[1,1]+" | "+board[1,2]+" |");
        Console.WriteLine("|___|___|___|");
        Console.WriteLine("| "+board[2,0]+" | "+board[2,1]+" | "+board[2,2]+" |");
        Console.WriteLine("|___|___|___|");
    }
}

