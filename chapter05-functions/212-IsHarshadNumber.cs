/*
 * Raul Gogna
 * Function IsHarshadNumber


A Harshad number (http://en.wikipedia.org/wiki/Harshad_number) is a number 
which is divisible by the sum of its digits. Create a function 
“IsHarshadNumber”, to return true if the number indicated as parameter is a 
Harshad number (2 points):

if (IsHarshadNumber (152))
    Console.WriteLine("152 is a Harshad number");

if ( ! IsHarshadNumber (121))
    Console.WriteLine("121 is not a Harshad number");

 */

using System;

public class FunctionIsHarshadNumber
{
    public static bool IsHarshadNumber(int num)
    {
        string number = Convert.ToString(num);
        int sum = 0;
        foreach (char c in number)
        {
            sum += Convert.ToInt32(Convert.ToString(c));
        }
        if (num % sum == 0)
        {
            return true;
        }
        else
            return false;
    }
    public static void Main()
    {
        Console.Write("Enter num: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (IsHarshadNumber(num))
            Console.WriteLine(num + " is a Harshad number");
        else
            Console.WriteLine(num + " is not a Harshad number");
    }
}
