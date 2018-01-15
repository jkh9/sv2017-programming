/*
Create a class RandomNumber, with three static methods:

- GetFloat will return a number between 0 and 1 using the 
  following algorithm:

  seed = (seed * a + c) % m
  result = abs(seed / m)

- GetInt(max) will return a number from 0 to max, using:

  result = round(max * GetFloat)

- GetInt(min, max) will return a number from min to max 
  (you must create this one totally on your own).

The starting values must be:

m = 233280;
a = 9301;
c = 49297;
seed = 1;

Create a test program, to use these 3 static methods to 
generate 3 random numbers.
*/

using System;

public class RandomNumber
{
    protected static float m = 233280.0f;
    protected static float a = 9301;
    protected static float c = 49297;
    protected static float seed = 1;

    public static float GetFloat()
    {
        seed = (seed * a + c) % m;
        return Math.Abs(seed / m);
    }

    public static int GetInt(int max)
    {
        return (int) (GetFloat() * max);
    }

    public static int GetInt(int min, int max)
    {
        return GetInt(max-min) + min;
    }
}

public class RandomTest
{
    public static void Main()
    {
        Console.WriteLine("Random float:");
        Console.WriteLine( RandomNumber.GetFloat() );
        Console.WriteLine( RandomNumber.GetFloat() );
        Console.WriteLine( RandomNumber.GetFloat() );

        Console.WriteLine("Random int, 0 to 200:");
        Console.WriteLine(RandomNumber.GetInt(200));
        Console.WriteLine(RandomNumber.GetInt(200));
        Console.WriteLine(RandomNumber.GetInt(200));

        Console.WriteLine("Random int, 100 to 160:");
        Console.WriteLine(RandomNumber.GetInt(100, 160));
        Console.WriteLine(RandomNumber.GetInt(100, 160));
        Console.WriteLine(RandomNumber.GetInt(100, 160));
    }
}
