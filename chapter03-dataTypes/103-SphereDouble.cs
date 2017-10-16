// Area and volume of a sphere (double)

using System;

class Sphere
{
    static void Main()
    {
        double pi = 3.1415926535;
        
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = 4 * pi * radius * radius;
        Console.WriteLine("Area = " + area);

        double volume = 4.0 / 3.0 * pi * radius *  radius * radius;
        Console.WriteLine("Volume = " + volume);
    }
}
