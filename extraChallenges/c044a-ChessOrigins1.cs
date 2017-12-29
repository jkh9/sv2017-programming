/*
Chess origins:
- Grains in the first tile
- Value to multiply each step
- Amount of tiles

Sample input
1 1 10
1 2 3
3 2 3
1 2 7
1 0 2
0 1 2
1 2 0
1 2 8
0 0 0

Sample output
10
7
21
127
1
0
0
255
*/

//Pedro Luis Coloma, corrections by Nacho

using System;
public class ch44
{
    public static void Main ()
    {
        long initAmount, mult, squares, total; //should be "long", not "double"

        do
        {
            string[] data = Console.ReadLine().Split(); // The input format was not correct
            initAmount = Convert.ToInt64(data[0]);
            mult = Convert.ToInt64(data[1]);
            squares = Convert.ToInt64(data[2]);

            // The next operations were not correct
            long currentAmount = 0;
            total = 0;
            if (squares > 0)
            {
                currentAmount = initAmount;
                total += currentAmount;
            }
            for (byte i = 1; i < squares; i++)
            {
                currentAmount *= mult;
                total += currentAmount;
            }

            //Console.WriteLine();  // Note: this line should not exist
            Console.WriteLine(total);
        } 
        // The exit condition was wrong: must use || instead of &&
        while (initAmount != 0 || mult != 0 || squares != 0);
    }
}
