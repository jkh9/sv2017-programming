// Get maximum value and second value: GetMax2

using System;

public class Ex233
{
    public static void Get2Max(float[] data, 
        out float max, out float second)
    {
        max = data[0];
        second = data[0];
        foreach (float n in data)
            if (n > max)
                max = n;
        foreach (float n in data)
            if (n < max && n > second)
                second = n;
    }


    public static void Main()
    {
        float max, second;
        float[] data = { 2, 7.5f, 6, -1, 20, 5 };
        Get2Max(data, out max, out second);

        Console.WriteLine("Maximum is " + max + ", second is " + second);
        
        // Note: it will fail in this case
        
        float[] data2 = { 20, 20, 7.5f, 6, -1, 20, 5 };
        Get2Max(data2, out max, out second);

        Console.WriteLine("Now maximum is " + max + ", second is " + second);
    }
}

