// Hollow Rectangle

using System;

public class HollowRectangle
{
    public static void Main()
    {
        Console.Write("Width? ");
        int width = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Height? ");
        int height = Convert.ToInt32(Console.ReadLine());
        
        // First row
        for (int column = width; column > 0; column--)
            Console.Write("X");
        Console.WriteLine();
        
        // Middle rows
        for (int row = height; row > 0; row--)
        {
            Console.Write("X");
            for (int space = width - 2; space > 0; space--)
                Console.Write(" ");
            Console.Write("X");
            Console.WriteLine();
        }
        
        // Last row
        for (int column = width; column > 0; column--)
            Console.Write("X");
        Console.WriteLine();
        
        
    }
}
        
