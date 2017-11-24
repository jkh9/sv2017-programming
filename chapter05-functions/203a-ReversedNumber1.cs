// Javier Saorín Vidal
using System;

public class Ex203
{
    public static int Reversed(int data)
    {
        string number = "" + data;
        string reversed = "";
        for (int i = number.Length -1; i >= 0; i--)
        {
            reversed += number[i];
        }

        return Convert.ToInt32(reversed);
    }

    public static void Main()
    {
        Console.WriteLine(Reversed(231));
    }
}
