// (c) Javier Saorín Vidal, Jose Vilaplana, Mireya Muñoz,
using System;
public class ThreeInLine
{
    static void Main()
    {
        const int SIZE = 3;
        char[,] ticTacToe = new char[SIZE, SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                ticTacToe[i, j] = '-';
            }
        }


        int row, col;
        Console.Write("Enter row. ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter column. ");
        col = Convert.ToInt32(Console.ReadLine());

        ticTacToe[row - 1, col - 1] = 'X';

        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                Console.Write(ticTacToe[i,j]);
            }
            Console.WriteLine();
        }
    }
}
