//Danie Miquel Sirera
//Exercise 52

/*
Write a program which asks the user for a height and a width and displays a 
rectangle of asterisks with that height and width, as in this example:

Width? 3
Height? 5

***
***
***
***
***

*/

using System;

public class Exercise52
{
    
    public static void Main()
    {
        
        int width,height,row,column;
        
        Console.Write("Width: ");
        width = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Height: ");
        height = Convert.ToInt32(Console.ReadLine());
        
        row = 0;
        while(row < height)
        {
            column = 0;
            while(column < width)
            {
                Console.Write("*");
                column = column + 1;
            }
            Console.WriteLine();
            row = row + 1;
        }
    }
}
