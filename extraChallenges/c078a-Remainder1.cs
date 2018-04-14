﻿/*
The remainder

Fibonacci numbers are generated with the equation:

f(n) = f(n-1) + f(n-2)

The list of numbers generated by this sequence are 1, 1, 2, 3, 5, 8, 13, 21, 
... etc. The first numbers of this sequence are defined as follows:

      i 0 1 2 3 4 5  6  7

Fib (i) 1 1 2 3 5 8 13 21

Given a number X we want to know the rest of dividing a certain Fibonacci 
number by X.

For example if X = 7, and i = 6, then the remainder would be 13% 7 = 6.

Input

An integer number (followed by Enter) and another integer number (followed by 
Enter).

For example, test your program with i = 19 and X = 29.

Output

Write the remainder of dividing the Fibonacci i by X on a line.

Examples

N i Answer
3 7 3
6 9 4
3 11 3
*/

//Almudena López Sánchez

using System;

public class FiboFunny
{
    public static int Fibonacci(int n)
    {
        //Final case
        if (n <= 1)
            return 1;
        //Generic case
        return Fibonacci(n-1)+Fibonacci(n-2);
    }

    public static void Main()
    {
        int i = Convert.ToInt32(Console.ReadLine());
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Fibonacci(i) % num);
    }
}