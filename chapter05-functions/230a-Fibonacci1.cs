//Javier Herreros Pozo

using System;

public class FunctionFibonacci
{
    public static int Fibonacci(int term)
    {
        if (term == 0)
            return 0;
        
        if (term == 1)
            return 1;
         
        return Fibonacci(term - 1) + Fibonacci(term - 2);
    }

    public static void Main()
    {
        int term;

        Console.WriteLine("Term:");
        term = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < term; i++)
        {
            Console.WriteLine("{0} =>  {1}", i, Fibonacci(i));
        }
    }
}
