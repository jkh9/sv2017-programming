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
            Console.Write("Columna: ");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fila: ");
            int row = Convert.ToInt32(Console.ReadLine());

            line[row -1, column-1] = 'X';

            for (int a = 0; a < BLOCKS; a++)
            {
                for (int i = 0; i < BLOCKS; i++)
                {
                    if (i == 2)
                        Console.Write(line[a, i]);
                    else
                        Console.Write(line[a, i] + "|");
                }
                Console.WriteLine();
            }

        }
        while (true);

    }
}
