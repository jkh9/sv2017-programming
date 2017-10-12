// Javier Cases Sempere

using System;

public class Ex89
{
    public static void Main()
    {
        int count = 0;
    repetir:
        Console.WriteLine("Hola");
        count++;
        if (count < 10)
            goto repetir;
    }
}
