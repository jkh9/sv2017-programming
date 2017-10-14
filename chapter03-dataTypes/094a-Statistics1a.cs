// Almudena Lopez Sanchez
// Statistics program

using System;

public class Statistics1
{
    public static void Main()
    {
        double num;
        double total=0;
        do
        {
            Console.WriteLine("Data? ");
            num = Convert.ToDouble(Console.ReadLine());
            
            if (num == 0)
                Console.WriteLine("Bye!");
            else
            {
                total+= num;
                Console.Write("Sum = "+total);
                Console.WriteLine();
            }
            
        }
        while(num != 0);
    }
}
