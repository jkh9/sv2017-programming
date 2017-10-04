//Victor Tebar
//Hollow rectangle

using System;

public class HollowRectangle
{
    public static void Main()
    {
        int width,height;
        
        Console.Write("Width? ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Height? ");
        height = Convert.ToInt32(Console.ReadLine());
        
        for(int row = 0; row < height; row++)
        {
            for(int column = 0; column < width; column++)
            {
                if((column == 0 || column == width-1) 
                        || (row == 0 || row == height-1))
                    Console.Write("X");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
