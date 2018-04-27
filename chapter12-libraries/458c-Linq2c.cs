/*
Obtain the numeric values stored in a space-separated string, 
such as "1 3 5 7 9", using LINQ
*/

//Señor Santana

using System;
using System.Linq;

public class Linq2c
{
    public static void Main(string[] args)
    {
        string numbers = "1 2 3 4 5 6 7 8 2 2 12 34";

        var results = from n in numbers.Split() 
            select int.Parse(n);
        Console.WriteLine(results.Sum());        
    }
}
