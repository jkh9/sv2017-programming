/*

Write a program to display a triangle of asterisks, with the size 
(height and width) chosen by the user, right aligned:

Size? 5

    *
   **
  ***
 ****
*****

*/

using System;
public class Triangle2
{   
    public static void Main()
    {
        int size;
        Console.Write("Size? ");
        size = Convert.ToInt32(Console.ReadLine());
        
        int spaces = size-1;
        int asteriks = 1;
        
        for (int row = 0; row < size; row++) 
        {   
            for (int column = 0; column < spaces; column++)
                Console.Write(" ");
            for (int column = 0; column < asteriks; column++)
                Console.Write("*");
            Console.WriteLine();
            
            spaces--;
            asteriks++;
        }
    }
}
