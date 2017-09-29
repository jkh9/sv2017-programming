// Pedro Coloma

using System;

public class DoWhile
{
    public static void Main()
    {
        int num1, num2;
        
        do
        {
            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if(!((num1==0) && (num2==0)))
                Console.WriteLine("{0}+{1}={2}",num1,num2,num1+num2);
        }
        while(!((num1==0) && (num2==0)));
        Console.WriteLine("Bye!");
    }
}
