// Moisex Encinas
// Counting the positive numbers

using System;
public class HowManyPositives
{
    public static void Main()
    {
        int positives = 0;
        int n1, n2;
        
        Console.Write("First number?: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Second number?: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        if (n1 > 0)
            positives = positives + 1;
            
        if (n2 > 0)
            positives = positives + 1;
            
        Console.WriteLine("Amount of positives: {0}", positives);
    }
}
