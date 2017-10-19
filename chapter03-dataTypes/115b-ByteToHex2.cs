// Byte to Hex 2

using System;

public class ByteToHex2
{
    public static void Main()
    {
        
        byte number;
        int remainder,result;
        
        Console.Write("Enter a number: ");
        number = Convert.ToByte(Console.ReadLine());
        Console.Write("In Hex is: ");
        
        result = number/16;
        remainder = number%16;
        
        if ( result < 10 )
            Console.Write(result);
        else
            Console.Write(Convert.ToChar('A' + result-10));
            
        if ( remainder < 10 )
            Console.Write(remainder);
        else
            Console.Write(Convert.ToChar('A' + remainder-10));
    }
}
            
