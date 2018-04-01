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
0.6666 -> 3333 / 5000
0.3333 -> 3333 / 10000
0.7777 -> 23331 / 30000

(Source: 2005 British Informatics Olympiad, Round 1, Problem 1)
*/

// Note: this version fails with 0.7777 -> 23331 / 30000 
//       should be 7777 / 10000)

//Almudena López Sánchez

using System;

public class Challenge76
{
    public static void Main()
    {
        string n = Console.ReadLine();
        n = n.Replace('.', ',');
        double num = Convert.ToDouble(n);
        double result = 0;
        int count = 1;
        int div = 1;
        do
        {
            count++;
            result = num * count;
            if (result > div)
                div++;
        }
        while (result != div);
        Console.WriteLine(div + " / " + count);
    }
}
