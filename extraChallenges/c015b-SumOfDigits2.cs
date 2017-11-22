// Challenge 15
// Gonzalo Martinez

// Note: fails for input 0

using System;

public class Challenge015
{
    public static void Main()
    {
        int number, sum, count;
        int[] data = new int[10];
        bool finished = false;
        
        do
        {
            sum = 0;
            count = 0;
            number = Convert.ToInt32(Console.ReadLine());
            
            if(number != -1)  // Note: this line was not correct
            {
                for(int i = 0; i < number; i++)
                {
                    data[i] = number % 10;
                    number /= 10;
                    count++;
                }
                if(number != 0)
                {
                    data[count] = number;
                    count++;
                }
                for(int j = count - 1; j >= 0; j--)
                {
                    Console.Write(data[j]);
                    sum += data[j];
                    if(j == 0)
                        Console.WriteLine(" = " + sum);
                    else
                        Console.Write(" + ");
                }
            }
            else
                finished = true;
                
        }while(!finished);
    }
}
