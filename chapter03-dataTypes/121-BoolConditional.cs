//Pedro Luis Coloma

using System;

public class WorkingTime
{
    public static void Main()
    {
        int a,b;
        bool even= false;
        
        Console.Write("Number 1? ");
        a = Convert.ToByte(Console.ReadLine());
        Console.Write("Number 2? ");
        b = Convert.ToByte(Console.ReadLine());
        
        if ((a%2 == 0) && (b % 2 == 0))
            even = true;
        Console.Write(even);
        
        even = (a%2 == 0) && (b % 2 == 0) ? true : false;
        Console.Write(even);
        
        even = (a%2 == 0) && (b % 2 == 0);
        Console.Write(even);
    }
}
