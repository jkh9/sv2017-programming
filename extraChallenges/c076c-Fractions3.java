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
0.3125 -> 5 / 16
0.012 -> 3 / 250
0.6666 -> 3333 / 5000
0.3333 -> 3333 / 10000

(Source: 2005 British Informatics Olympiad, Round 1, Problem 1)
*/

//package javachallenges;

import java.util.Scanner;

/**
 *
 * @author Moises Encinas
 */
public class Fractions3
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        String decimal = sc.nextLine();
        String number = "1";
        for (int i = 0; i < decimal.length() - 2; i++)
        {
            number += "0";
        }
        
        int divisor = Integer.valueOf(number);
        int dividendo = Integer.valueOf(decimal.substring(2));
        
        for (int i = 2; i < dividendo; i++)
        {
            do
            {
                if (dividendo % i == 0 && divisor % i == 0)
                {
                    dividendo /= i;
                    divisor /= i;
                }
            } while (dividendo % i == 0 && divisor % i == 0);
        }
        
        System.out.print(dividendo);
        System.out.print(" / ");
        System.out.print(divisor);
    }
}
