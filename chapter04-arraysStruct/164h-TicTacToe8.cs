//Moisés, Nacho, Raul
using System;

public class ThreeInARow
{
    public static void Main()
    {
        const int BLOCKS = 3;
        char[,] line = new char[BLOCKS, BLOCKS];

        do
        {
            Console.Write("Column: ");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.Write("Row: ");
            int row = Convert.ToInt32(Console.ReadLine());

            line[row -1, column-1] = 'X';

            for (int a = 0; a < BLOCKS; a++)
            {
                Console.WriteLine("+-+-+-+");
                for (int i = 0; i < BLOCKS; i++)
                {
                    Console.Write("|"+line[a, i]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+-+-+-+");
        }
        while (true);

    }
}
