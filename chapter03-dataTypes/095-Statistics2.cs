// Almudena Lopez Sanchez
// Statistics program (2)

using System;
public class Statistics2
{
    public static void Main()
    {
        double num;
        double total=0;
        double count=0;
        do
        {
            Console.WriteLine("Data? ");
            num = Convert.ToDouble(Console.ReadLine());
            
            if( num != 0 )
            {
                count++;
                total+= num;
                Console.Write("Sum = "+total+
                    ", Avg = "+total/count);
                Console.WriteLine();
            }
        }
        while(num != 0);
        Console.WriteLine("Bye!");
    }
}
