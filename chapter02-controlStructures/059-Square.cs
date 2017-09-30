// Lucía Navarro Vélez
// Square

using System;
public class Square
{   
    public static void Main()
    {
        int size;
        Console.Write("Size of the square? ");
        size = Convert.ToInt32(Console.ReadLine());
        for (int row = 0; row < size; row++) 
        {   
            for (int column = 0; column < size; column++)
                Console.Write("#");
            Console.WriteLine();
        }
    }
}
