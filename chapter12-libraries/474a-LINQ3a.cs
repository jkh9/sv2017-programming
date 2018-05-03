// Create a program to ask the user for 10 numbers, store them 
// in an array and display the positive ones, sorted ascending, 
// using LINQ

using System;
using System.Linq;
using System.Collections.Generic;

class Linq1
{
    static void Main(string[] args)
    {
        List<double> nums = new List<double>();

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter a number ("+(i+1)+
                "/10): ");
            nums.Add(Convert.ToDouble(Console.ReadLine()));
        }

        /*
        var result =
            from n in nums
            where n > 0
            orderby n
            select n;
		*/

        var result = nums
			.Where(n => n > 0)
			.OrderBy(n => n);
        
        foreach (double i in result)
            Console.Write(i + " ");
    }
}
