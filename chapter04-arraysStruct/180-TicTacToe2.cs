// Tic tac toe V2
// Victor, Miguel Garcia, Gonzalo. Corrections by Nacho

using System;

public class TicTacToe2
{
    public static void Main()
    {
        const int BOARD_SIZE = 3;
        char[,] line = new char[BOARD_SIZE, BOARD_SIZE];
        int column, row;
        int currentPlayer = 1;

        do
        {
            Console.Clear();
            for (int r = 0; r < BOARD_SIZE; r++)
            {
                Console.WriteLine("+-+-+-+");
                for (int c = 0; c < BOARD_SIZE; c++)
                {
                    Console.Write("|" + line[r, c]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+-+-+-+");
            Console.WriteLine();

            do
            {
                Console.Write("Column: ");
                column = Convert.ToInt32(Console.ReadLine());
                Console.Write("Row: ");
                row = Convert.ToInt32(Console.ReadLine());
            } while (line[row - 1, column - 1] == 'O'
                || line[row - 1, column - 1] == 'X');

            if (currentPlayer == 1)
                line[row - 1, column - 1] = 'X';
            else
                line[row - 1, column - 1] = 'O';

            currentPlayer = currentPlayer == 1 ? 2 : 1;
        }
        while (true);
    }
}
