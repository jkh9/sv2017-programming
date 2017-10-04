// Javier Cases Sempere
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
        
        
        for (int row = height; row > 0; row--)
        {
            Console.Write("X");
            
            if (row == height || row == 1)
                for (int column = width - 2; column > 0; column--)
                    Console.Write("X");
            else
                for (int space = width - 2; space > 0; space--)
                    Console.Write(" ");
            
            Console.Write("X");
            
            Console.WriteLine();
        }
    }
}
        
