// Javier Cases Sempere

using System;

public class Ex49
{
    public static void Main()
    {
        int n1, n2;
        
        do
        {
            Console.Write("Enter a number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter another number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            if (n1 != 0 || n2 != 0)
                Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
        }
        while (n1 != 0 || n2 != 0);
        
        Console.WriteLine("Bye!");
    }
}
