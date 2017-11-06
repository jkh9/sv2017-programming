using System;

public class TicTacToe1
{
    public static void Main()
    {
        const int BOARD_SIZE = 3;
        char[,] line = new char[BOARD_SIZE, BOARD_SIZE];

        do
        {
            Console.Write("Column: ");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.Write("Row: ");
            int row = Convert.ToInt32(Console.ReadLine());

            line[row -1, column-1] = 'X';

            for (int r = 0; r < BOARD_SIZE; r++)
            {
                Console.WriteLine("+-+-+-+");
                for (int c = 0; c < BOARD_SIZE; c++)
                {
                    Console.Write("|"+line[r, c]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+-+-+-+");
            Console.WriteLine();
        }
        while (true);
    }
}
