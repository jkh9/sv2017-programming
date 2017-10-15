// angel rebollo berna

using System;

public class Statistics4
{
    public static void Main()
    {
        int count = 0;
        Console.Write("Data? ");
        string answer = Console.ReadLine();
        double data, min,max;
        double sum = 0;
        
        if (answer != "end")
        {
            min = max = Convert.ToDouble(answer);

            while (answer != "end")
            {
                data = Convert.ToDouble(answer);
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
                answer = Console.ReadLine();
            }
        }
        Console.WriteLine("Bye!");
    }
}
