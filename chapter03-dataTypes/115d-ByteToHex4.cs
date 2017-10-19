// Byte to Hex 4
// Daniel Miquel Sirera

using System;

public class ByteToHex4
{

    public static void Main()
    {
        byte number;
        Console.Write("Enter a number: ");
        number = Convert.ToByte(Console.ReadLine());
        Console.Write("In Hex is: " + 
            Convert.ToString(number, 16) );
    }
}

