// Byte to binary (1: for, 8 bits, int)

using System;
public class Binary1
{
    public static void Main()
    {
        Console.Write("Number to convert?: ");
        int n = Convert.ToByte(Console.ReadLine());
        Console.Write("In binary is: ");
        
        string binary = "";
        for (int i = 0; i < 8; i++)  // byte = 8 bits
        {
            if (n%2 == 0)
                binary = "0" + binary;
            else 
                binary = "1" + binary;
            n = n / 2;
        }
        Console.WriteLine(binary);
    }
}
