//Almudena Lopez Sanchez
using System;

public class Ex330
{
    public static byte MaxDigit(long num)
    {
        string n = Convert.ToString(num);
        char max = n[0];
        foreach(char c in n)
        {
            if (c > max)
                max = c;
        }
        return Convert.ToByte(""+max);
    }

    public static void Main()
    {
        
        Console.WriteLine(MaxDigit(32));
    } 
}

