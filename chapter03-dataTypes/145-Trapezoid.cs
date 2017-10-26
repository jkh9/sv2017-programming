/*

Write a program which asks for a width and a height (both will be "byte" 
values), and displays a trapezoid like this one:

Enter the desired width: 5
Enter the desired height: 3


..*****..
.*******.
*********

*/

using System;

public class Trapezoid
{   
    public static void Main()
    {
        Console.Write("Width? ");
        int width = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Height? ");
        int height = Convert.ToInt32(Console.ReadLine());
        
        int spaces = height-1;
        int asteriks = width;
        
        for (int row = 0; row < height; row++) 
        {   
            for (int column = 0; column < spaces; column++)
                Console.Write(".");
            for (int column = 0; column < asteriks; column++)
                Console.Write("*");
            for (int column = 0; column < spaces; column++)
                Console.Write(".");
            Console.WriteLine();
            
            spaces--;
            asteriks += 2;
        }
    }
}
