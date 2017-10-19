// Byte to binary (2: while, n bits, int)

using System;
public class Binary2
{
    public static void Main()
    {
        Console.Write("Number to convert?: ");
        int n = Convert.ToByte(Console.ReadLine());
        Console.Write("In binary is: ");
        
        string binary = "";
        while (n > 0)
        {
            if (n%2 == 0)
                binary = "0"+binary;
            else 
                binary = "1" +binary;
            n = n / 2;
        }
        Console.WriteLine(binary);
    }
}
