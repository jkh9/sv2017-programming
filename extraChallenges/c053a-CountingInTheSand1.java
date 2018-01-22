/*
Challenge 053: Counting in the sand (acepta 369)
Input

The input will consist of different numbers greater than 0 and that will never 
be greater than 1,000, each one in a line.

The entry ends with a 0, which should not be processed.

Ouput

For each number you must write, in a separate line, its coding in base 1.

Example input
1
4
6
0

Example output
1
1111
111111
*/

// Moisés Encinas

import java.util.Scanner;

public class Challenge369
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        int number;
        do
        {
            number = sc.nextInt();
            if (number != 0)
            {
                for (int i = 0; i < number; i++)
                {
                    System.out.print("1");
                }
                System.out.println();
            }
        } while (number != 0);
    }
}
