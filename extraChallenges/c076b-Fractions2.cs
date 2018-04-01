/*
Fractions

Given a decimal fraction we can write it as a proper fraction in its lowest 
form. Recall that a proper fraction a/b is in its lowest form if it is not 
possible to divide a and b by a common factor.

For example, 0.25 is written as 1/4 in its lowest form.

For the whole of this question, we are only interested in proper fractions in 
their lowest form.

Write a program which, given a decimal fraction between 0.0001 and 0.9999 
inclusive (and no more than four decimal places), outputs the equivalent proper 
fraction. The input will always  start with a 0 before a decimal point, and all 
decimal fractions are exact (i.e. they are not just  approximations to four 
decimal places).

Sample run

0.125

1 / 8

Other examples:
0.4 -> 2 / 5
0.3125 = 5 / 16
0.012 -> 3 / 250
0.6666 -> 3333 / 5000
0.3333 -> 3333 / 10000

(Source: 2005 British Informatics Olympiad, Round 1, Problem 1)
*/

// by Renata Pestana Ribeiro, a minor correction by Nacho

using System;

class East_076
{
    static void Main(string[] args)
    {
        string[] numStr = Console.ReadLine().Split('.');
        int size,numerator, denominator;
        string divisor = "1";
        size = numStr[1].Length;
        //if(Convert.ToDouble(numStr)>= 0.0001 || Convert.ToDouble(numStr) >= 0.9999)
        //{
            for (int i = 0; i < size; i++)
            {
                divisor += "0";
            }
            denominator = Convert.ToInt32(divisor);
            numerator = Convert.ToInt32(numStr[1]);
            // Ayuda para depuración
            // Console.WriteLine(numerator + "/" + denominator);
            while ((numerator % 2 == 0) && (denominator % 2 == 0))
            {
                numerator /= 2;
                denominator /= 2;
            }
            while ((numerator % 5 == 0) && (denominator % 5 == 0))
            {
                numerator /= 5;
                denominator /= 5;
            }
            Console.WriteLine(numerator + " / " + denominator);
        //}
    }
}
