/*
Create a program to display a (console) screen with several 
"snowflakes" (using, for example, 100 asterisks). First you must do 
this using a two-dimensional array of characters.

When the user presses Enter, you will have to do it again, but this 
time using advanced console options: clear the screen, place the cursir 
in random coordinates with SetCursorPosition and wait for any key to be 
pressed with ReadKey.
*/

using System;

public class Snowflakes
{
    public static void Main()
    {
        const byte WIDTH = 79;
        const byte HEIGHT = 24;
        const byte SNOWFLAKES = 100;

        // First way:using an array

        // Let's create the array and empty it
        char[,] buffer = new char[HEIGHT, WIDTH];
        for (byte row = 0; row < HEIGHT; row++)
            for (byte col = 0; col < WIDTH; col++)
                buffer[row, col] = ' ';

        // Now let's place the snowflakes
        Random random = new Random();
        for (byte i = 0; i < SNOWFLAKES; i++)
        {
            int x = random.Next(0, WIDTH);
            int y = random.Next(0, HEIGHT);
            buffer[y, x] = '*';
        }

        // And finally let's display everything
        for (byte row = 0; row < HEIGHT; row++)
        {
            for (byte col = 0; col < WIDTH; col++)
                Console.Write(buffer[row, col]);
            Console.WriteLine();
        }
        Console.ReadLine();

        // Second way: Adanced Console usage
        Console.Clear();
        for (byte i = 0; i < SNOWFLAKES; i++)
        {
            int x = random.Next(0, WIDTH);
            int y = random.Next(0, HEIGHT);
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
        Console.ReadKey();
    }
}
