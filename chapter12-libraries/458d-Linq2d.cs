/*
Obtain the numeric values stored in a space-separated string, 
such as "1 3 5 7 9", using LINQ
*/

using System;
using System.Linq;

public class Linq2d
{
    public static void Main(string[] args)
    {
        string numbers = "1 2 3 4 5 6 7 8 2 2 12 34";

        Console.WriteLine(
            numbers.Split().Select(int.Parse).Sum());        
    }
}
