//Guillermo Pastor
using System;

public class Ex
{
    public static bool IsPrime(long num)
    {
        long dividers = 0;

        for (long i=1; i<=num; i++)
        {
            if (num % i == 0)
                dividers++;
        }
        if (dividers == 2)
            return true;
        else
            return false;
    }
    
    public static bool IsPalindrome(string a)
    {
        
        string reversed = "";

        for (int i = 0; i < a.Length; i++)
        {
            reversed = a[i] + reversed;
        }

        if (reversed == a)
            return true;
        else
            return false;
    }
    
    public static bool IsPrimePalindrome(long num)
    {
        if (IsPrime(num) && IsPalindrome(num.ToString()))
            return true;
        else
            return false;
    }
    
    public static void Main()
    {
        Console.Write("Enter a number: ");
        long number1 = Convert.ToInt64(Console.ReadLine());
        Console.Write("Enter a number: ");
        long number2 = Convert.ToInt64(Console.ReadLine());
        
        DateTime start = DateTime.Now;
        long amount = 0;
        for(long i = number1; i <= number2; i++)
        {
            if(IsPrimePalindrome(i))
            {
                Console.Write(i+" ");
                amount ++;
            }
        }
        Console.WriteLine("These numbers are prime & palindrome");
        Console.WriteLine("Total: {0} numbers", amount);
        Console.WriteLine("Time taken: {0}", DateTime.Now-start);
    }
}
