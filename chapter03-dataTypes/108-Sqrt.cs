// Miguel García Gil
// Area, perimeter and diagonal of a rectangle

using System;

public class Even
{
    public static void Main()
    {
        double heigth, width;
        
        Console.Write ("Enter width: ");
        width = Convert.ToDouble (Console.ReadLine());
        
        Console.Write ("Enter heigth: ");
        heigth = Convert.ToDouble (Console.ReadLine());
        
        double area = width * heigth;
        double perimeter = width * width + heigth * heigth;
        double diagonal = Math.Sqrt (width*width + heigth*heigth);
        
        Console.WriteLine ("Area: " + area);
        Console.WriteLine ("Perimeter: " + perimeter);
        Console.WriteLine ("Diagonal: " + diagonal);
    }
}
