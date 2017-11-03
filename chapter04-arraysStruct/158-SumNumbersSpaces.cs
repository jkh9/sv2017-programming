/*
Create a program to ask the user for a text line containing 
space-separated numbers and display their sum. For example:

? 20 30 41 2

Their sum is 93
*/

//Querubin Santana

using System;

public class SumString
{
    public static void Main()
    {
        string numbers;
        double sum = 0;
        
        Console.Write("Enter some numbers separated by spaces ");
        numbers = Console.ReadLine();
        string[] nums = numbers.Trim().Split();        
        foreach(string number in nums)
        {
           sum += Convert.ToDouble(number);
        }
        Console.WriteLine("The sum of all numbers is {0}", sum);
    }
}
