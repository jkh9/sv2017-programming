// Byte to binary (6: Convert.ToString)

using System;
public class Binary6
{
    public static void Main()
    {
        Console.Write("Number to convert?: ");
        byte n = Convert.ToByte(Console.ReadLine());
        Console.Write("In binary is: ");
        Console.WriteLine( Convert.ToString(n,2) );
    }
}
