/*
An integer is called a palindrome if it is equal to its reverse. For example, 
79197 and 324423 are palindromes. 

Create a program which, given an integer N, 1 <= N <= 1.000.000, will display 
smallest integer M >= N such that M is a prime number and M is a palindrome.

For example, if N is 31 then the answer is 101; if N is 600.000, the answer is 
1.003.001
*/

//by Renata Pestana Ribeiro, simplified by Nacho

using System;

public class PrimePalindrome
{
    static bool IsPrime(long n)
    {
        for (long i = 2; i < n/2; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static bool IsPalindrome(string n)
    {
        string reversed = "";

        for (int i = 0; i < n.Length; i++)
        {
            reversed = n[i] + reversed;
        }

        if (reversed == n)
            return true;
        else
            return false;
    }

    static long FindPalindrome(long num)
    {
        bool finished = false;
        do
        {
            string numStr = Convert.ToString(num);
            if (IsPalindrome(numStr) && IsPrime(num))
                finished = true;
            else
                num++;
        } while (!finished);
        return num;
    }

    public static void Main(string[] args)
    {
        long num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(FindPalindrome(num));
    }
}
