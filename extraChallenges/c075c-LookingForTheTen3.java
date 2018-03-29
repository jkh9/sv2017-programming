/*
Looking for the Ten

You are given all the marks you have obtained in a class. Each mark is between 
0 and 10 inclusive.

Assuming that in all your next tasks you will get a 10, determine the number of 
tasks necessary to obtain a 10. You will receive a 10 if your average is 9.5 or 
higher.

For example, if your marks are 8, 9 then you will require 4 additional tasks in 
which you will have to get 10. With each task your average would be increased 
to 9, 9.25, 9.4 and 9.5.

Input

The entry is in a line that contains all the notes you got separated by a comma.

Output

Write in one line the number of tasks required to obtain a 10.


Input examples

9,10,10,9
8,9
0,0,0,0,0,0,0,0,0,0,0,0,0
10,10,10,10

Output examples

0
4
247
0


The problem you must solve:

For the next entry, write a program that finds the answer.
7,7,10,10,4,6,4,6,0,6,7,4,6,6,9

The answer you should obtain is:
101

(First Bolivian Computing Olympiad, Level 3, Type 1, Problem 1)
*/

// Moisés Encinas

//package javachallenges;
import java.util.Scanner;

public class LookingForTheTen3
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        // while (sc.hasNextLine())
        {
            String numbers = sc.nextLine();
            String[] eachNumber = numbers.split(",");

            double total = 0;
            int marks = eachNumber.length; 

            for (int i = 0; i < eachNumber.length; i++)
            {
                total += Double.parseDouble(eachNumber[i]);
            }

            do
            {
                if ((total / marks) < 9.5)
                {
                    total += 10;
                    marks++;
                }
            } 
            while ((total / marks) < 9.5);

            System.out.println(marks - eachNumber.length);
        }
    }
}
