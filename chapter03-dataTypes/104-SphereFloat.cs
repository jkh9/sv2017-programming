// Area and volume of a sphere (float)

using System;

class Sphere
{
    static void Main()
    {
        float pi = 3.1415926535f;
        
        Console.Write("Enter radius: ");
        float radius = Convert.ToSingle(Console.ReadLine());

        float area = 4 * pi * radius * radius;
        Console.WriteLine("Area = " + area);

        float volume = 4.0f / 3.0f * pi * radius *  radius * radius;
        Console.WriteLine("Volume = " + volume);
    }
}
