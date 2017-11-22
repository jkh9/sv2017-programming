//Lucía Navarro
//Square Functions
using System;

public class Square
{

    public static void Main()
    {
       
        DisplaySquare('*',5);
       
    }
    public static void DisplaySquare(char symbol, int size)
    {
        
        for (int row = 0; row < size; row++)
        {
            for (int column = 0; column < size; column++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }   
}
