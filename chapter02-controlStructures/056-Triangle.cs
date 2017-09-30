//Exercise 56

/*
Display a left-aligned growing triangle, with the size 
chosen by the user

Size? 5
*
**
***
****
*****

*/

using System;

public class Triangle
{
    
    public static void Main()
    {
        
        int size,row,column;
        
        Console.Write("Size? ");
        size = Convert.ToInt32(Console.ReadLine());
        
        row = 1;
        while(row <= size)
        {
            column = 0;
            while(column < row)
            {
                Console.Write("*");
                column = column + 1;
            }
            Console.WriteLine();
            row = row + 1;
        }
    }
}
