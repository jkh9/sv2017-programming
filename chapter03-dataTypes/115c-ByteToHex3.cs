// Byte to Hex 3

using System;

public class ByteToHex3
{

    public static void Main()
    {
        byte number;
        Console.Write("Enter a number: ");
        number = Convert.ToByte(Console.ReadLine());
        Console.Write("In Hex is: " + number.ToString("X") );
    }
}

