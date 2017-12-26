//Almudena Lopez Sanchez
//Challenge 024 - Primacity
//He utilizado la base del anterior challenge, asi que igual de lento

/*
The primacity of an integer is the number of distinct primes which divide it.

Given 3 integers A, B, and K, how many integers in the inclusive range [A, B] 
have a primacity of exactly K?

Example input

5
5 15 2
2 10 1
24 42 3
1000000 1000000 1
1000000 1000000 2

Example output

Case #1: 5
Case #2: 7
Case #3: 2
Case #4: 0
Case #5: 1

(Facebook Hackercup 2015, problem 1)
*/

using System;

public class Challenge24
{
    public static bool IsPrime(int num)
    {
        for(int i = 2; i < num; i++)
        {
            if(num % i == 0)
                return false;
        }
        
        return true;
    }
    public static int IsAlmostPrime(int num1, int num2,int primacity)
    {
        int count = 0;
        int primac;
        int[] primos = new int[num2];
        int contArray = 0;
        for(int n = 2; n <= num2; n++)
        {
            if (IsPrime(n))
            {
                primos[contArray] = n;
                contArray++;
            }
        }
        for( int numeros = num1; numeros <= num2; numeros++)
        {
            primac = 0;
            int num = numeros;
            for(int p = 0; p < contArray; p++)
            {
                if (num % primos[p] == 0)
                {
                    primac++;
                    num /= primos[p];
                }
            }

            if (primacity == primac)
            {
                // Para ver cuales son los numeros que cumplen la primacity
                //Console.WriteLine(numeros);
                count++;
            }    
        }

        return count;
    }
    public static void Main()
    {
        int num;
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            string[] nums = Console.ReadLine().Split();
            Console.Write("Case #"+i+": ");
            Console.WriteLine(IsAlmostPrime(Convert.ToInt32(nums[0]),
                Convert.ToInt32(nums[1]), Convert.ToInt32(nums[2])));
        }
    }
}
