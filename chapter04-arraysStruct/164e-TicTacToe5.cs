// Guillermo Pastor Pastor, Pedro Coloma, Miguel Puerta, Angel Rebollo

using System;

public class SuperHardSum
{
    public static void Main()
    {
        const int row = 3, col = 3;
        char[,] tictac = new char[row,col];

        Console.WriteLine("row");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("col");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (y == j)
                {
                    if (x == i)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
        }
    }
}
