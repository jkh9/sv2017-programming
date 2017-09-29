// Almudena Lopez Sanchez
// Is a number prime?

using System;

public class IsPrime
{
    public static void Main()
    {
        int num,count,dividers = 0;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        count = num;
        
        while(count > 0)
        {
            if(num % count == 0)
                dividers = dividers + 1;
                
            count = count - 1;
        }
        if(dividers == 2)
            Console.WriteLine("{0} is prime.",num);
        else
            Console.WriteLine("{0} is not a prime.",num);
    }
}
