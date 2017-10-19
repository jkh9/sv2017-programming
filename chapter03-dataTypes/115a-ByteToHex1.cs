// Byte to Hex
// Daniel Miquel Sirera

using System;

public class ByteToHex1
{
    public static void Main()
    {
        
        byte number;
        int remainder,result;
        
        Console.Write("Enter a number: ");
        number = Convert.ToByte(Console.ReadLine());
        Console.Write("In Hex is: ");
        
        result = number / 16;
        remainder = number % 16;
        
        switch(result)
        {
            case 10: Console.Write("A");break;
            case 11: Console.Write("B");break;
            case 12: Console.Write("C");break;
            case 13: Console.Write("D");break;
            case 14: Console.Write("E");break;
            case 15: Console.Write("F");break;
            default : Console.Write(result);break;
        }

        switch(remainder)
        {
            case 10: Console.Write("A");break;
            case 11: Console.Write("B");break;
            case 12: Console.Write("C");break;
            case 13: Console.Write("D");break;
            case 14: Console.Write("E");break;
            case 15: Console.Write("F");break;
            default : Console.Write(remainder);break;
        }
    }
}
            
