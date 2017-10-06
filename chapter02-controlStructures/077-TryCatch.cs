// Angel Rebollo Berna
// Contact with exceptions

using System;

public class Exceptions
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1/num2);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }
}
