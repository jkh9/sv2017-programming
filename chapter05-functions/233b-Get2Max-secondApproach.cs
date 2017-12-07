// Get maximum value and second value: GetMax2
// Javier Saorín Vidal

using System;
public class Ex233
{
    public static void Get2Max(float[] d, ref float m1, ref float m2)
    {
        Array.Sort(d);
        m1 = d[d.Length - 1];
        m2 = d[d.Length - 2];
    }

    public static void Main(string[] args)
    {
        float max1 = 0, max2 = 0;
        float[] data = { 2, 7.5f, 6, -1, 20, 5 };

        Get2Max(data, ref max1, ref max2);

        Console.WriteLine("Max 1: " + max1);
        Console.WriteLine("Max 2: " + max2);
        
        // Note: arrays are passed by the reference, so data are altered:
        
        Console.WriteLine("Now the first data is: " + data[0]);
    }
}
