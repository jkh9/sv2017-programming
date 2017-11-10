/* 
 *  Brandon Blasco Del Cid, Ex178.cs
 */
using System;

public class RectangleNewString
{
    public static void Main()
    {
        int width, height;
        
        Console.Write("Enter a width: ");
        width = Convert.ToInt32(Console.ReadLine());
        string line = new String('*', width);
        
        Console.Write("Enter a height: ");
        height = Convert.ToInt32(Console.ReadLine());
        
        for (int row = 0; row < height; row++)
        {
            Console.WriteLine(line);
        }
    }
}
