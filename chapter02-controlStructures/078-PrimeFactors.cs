// Gonzalo Martinez
// Prime factors

using System;

public class Ex78
{
    public static void Main()
    {
        int num, div = 2, count = 0;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Write("{0} = ", num);
        
        while(count <= num)
        {
            while(num % div == 0)
            {
                num = num / div;
                Console.Write("{0} ", div);
            }
            div++;
            count++;   
        }    
    }
}
