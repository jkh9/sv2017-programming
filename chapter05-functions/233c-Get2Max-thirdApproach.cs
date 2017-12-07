// Get maximum value and second value: GetMax2
// Javier Saorín Vidal

using System;
public class Ex233
{
    public static void Get2Max(float[] d, out float m1, out float m2)
    {
        // Arrays are passed by reference, so we make a copy of it
        float[] d2 = new float[d.Length];
        Array.Copy(d, d2, d.Length);
        Array.Sort(d2);
        m1 = d2[ d2.Length - 1 ];
        m2 = d2[ d2.Length - 2 ];
    }

    public static void Main(string[] args)
    {
        float max1, max2;
        float[] data = { 2, 7.5f, 6, -1, 20, 5 };

        Get2Max(data, out max1, out max2);

        Console.WriteLine("Max 1: " + max1);
        Console.WriteLine("Max 2: " + max2);

        // Note: it will fail in this case

        float[] data2 = { 20, 20, 7.5f, 6, -1, 20, 5 };
        Get2Max(data2, out max1, out max2);

        Console.WriteLine("Now maximum is " + max1 + ", second is " + max2);
    }
}
