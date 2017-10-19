// Byte to binary (5: byte, /=)

using System;
public class Binary5
{
    public static void Main()
    {
        Console.Write("Number to convert?: ");
        byte n = Convert.ToByte(Console.ReadLine());
        Console.Write("In binary is: ");
        
        string binary = "";
        while (n > 0)
        {
            if (n%2 == 0)
                binary = "0"+binary;
            else 
                binary = "1"+binary;
            n /= 2;
        }
        Console.WriteLine(binary);
    }
}
