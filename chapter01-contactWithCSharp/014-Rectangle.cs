//Marcos Cervantes
//Area and perimeter of a rectangle

using System;

public class Rectangle
{
    public static void Main()
    {
        int a, b;
        int perimeter, area;
        
        Console.Write("Height? ");
        a= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Width? ");
        b= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        
        perimeter= a + b + a + b;
        area= a * b;

        Console.Write("Perimeter: ");
        Console.WriteLine(perimeter);
        Console.WriteLine();
        Console.Write("Area: ");
        Console.WriteLine(area);
        Console.WriteLine();
    }   
}   
