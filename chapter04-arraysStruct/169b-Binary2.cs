/*
Binary

Create a program that asks the user for a positive integer number and displays 
its equivalent in binary form. Assume the number fits in 8 bits (a byte).

The algorithm is as follows: divide the number by 2 as many times as possible 
until the number becomes one, and take all the remainders in reverse order:

35 : 2 = 17, remainder 1
17 : 2 = 8, remainder 1
8 : 2 = 4, remainder 0
4 : 2 = 2, remainder 0
2 : 2 = 1, remainder 0
1, finished

so the number would be 00100011.

You can use ".ToString" to verify your algorithm, but not as the only 
resolution method.

*/

using System;

public class Binary
{
    public static void Main()
    {
        byte number;
        byte[] binary = new byte[8];

        Console.Write("Enter a number: ");
        number = Convert.ToByte(Console.ReadLine());

        // For verification purposes
        string binary2 = Convert.ToString(number, 2);

        for (int i = 0; i<8; i++)
        {
            binary[7-i] = (byte)(number % 2);
            number /= 2;
        }

        foreach(byte b in binary)
            Console.Write(b);
        Console.WriteLine();

        //Verification
        Console.WriteLine(binary2);
    }
}
