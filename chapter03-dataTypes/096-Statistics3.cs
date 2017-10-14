// angel rebollo berna

using System;

public class Statistics3
{
    public static void Main()
    {
        int count = 0;
        Console.Write("Data? ");
        double data = Convert.ToDouble(Console.ReadLine());
        double sum = 0;
        
        double min = data;
        double max = data;
        
        while (data != 0)
        {
            count++;
            
            if (data > max)
                max = data;
            if (data < min)
                min = data;
            
            sum = sum + data;
            Console.WriteLine(
                "max: {0}, min: {1}, sum: {2}, Avg: {3}",
                max, min, sum, sum/count);
            
            Console.Write("Data? ");
            data = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Bye!");
    }
}
