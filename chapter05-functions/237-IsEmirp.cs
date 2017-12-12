/*
 * Raul Gogna
 * FunctionIsEmirp
 */

using System;

public class FunctionIsEmirp
{
    public static bool IsPrime(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    public static bool IsEmirp(int n)
    {
        if (IsPrime(n))
        {
            string num = n + "";
            string reverse = "";
            foreach (char c in num)
            {
                reverse = c + reverse;
            }
            int n2 = Convert.ToInt32(reverse);
            // Console.WriteLine(n2);
            if (n != n2 && IsPrime(n2))
                return true;
        }
        return false;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (IsEmirp(n))
        {
            Console.WriteLine("Is Emirp");
        }
        else
            Console.WriteLine("Is not Emirp");
        
        Console.WriteLine("Emirps from 1 to 100.000:");
        for (int i = 2; i <= 100000; i++)
            if (IsEmirp(i))
                Console.Write( i + " ");
        Console.WriteLine();
    }
}
