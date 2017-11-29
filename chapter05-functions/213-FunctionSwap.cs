// Marcos Cervantes
// Function Swap
using System;
public class Ex213
{
    public static void Swap(ref int x, ref int y)
    {
        int aux = x;
        x = y;
        y = aux;
    }
    
    public static void Main()
    {
        int x=2, y=3;
        Swap(ref x, ref y);
        Console.WriteLine("x={0}, y={1}", x, y);
    }
}
