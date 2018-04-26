// Create a program to ask the user for 10 numbers, store them in an array 
// and display the positive ones, sorted ascending, using LINQ

//Moiséx Encinas Picazo

using System;
using System.Diagnostics;
using System.Linq;

public class Linq1
{
    public static void Main(string[] args)
    {
        double[] numbers = new double[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter a number ("+(i+1)+
                "/10): ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        var results = from n in numbers
                      where n > 0
                      orderby n
                      select n;

        foreach (var item in results)
        {
            Console.Write(item + " ");
        }
    }
}
