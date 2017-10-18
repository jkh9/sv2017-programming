/*

Write a program which asks for a width and a symbol and displays
a right-aligned descending triangle of that width, as in this example:


Size? 5
Symbol? *

*****
 ****
  ***
   **
    *
*/

using System;
public class TriangleChar
{   
    public static void Main()
    {
        int size;
        char symbol;
        
        Console.Write("Size? ");
        size = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Symbol? ");
        symbol = Convert.ToChar(Console.ReadLine());

        
        int spaces = 0;
        int asteriks = size;
        
        for (int row = 0; row < size; row++) 
        {   
            for (int column = 0; column < spaces; column++)
                Console.Write(" ");
            for (int column = 0; column < asteriks; column++)
                Console.Write(symbol);
            Console.WriteLine();
            
            spaces++;
            asteriks--;
        }
    }
}
