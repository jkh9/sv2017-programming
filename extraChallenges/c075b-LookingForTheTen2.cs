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

//by Renata Pestana Ribeiro

using System;

class East_075
{
    static void Main(string[] args)
    {
        double sum = 0, avg; 
        int temp,cont=0;
        // Console.WriteLine("Enter with the marks.");
        string[] marks = Console.ReadLine().Split(',');
        double[] mark = new double[marks.Length];
        for (int i = 0; i < marks.Length; i++)
        {
            mark[i] = Convert.ToDouble(marks[i]);
        }
        for (int i = 0; i < marks.Length; i++)
        {
            sum = mark[i] + sum;
            if (i == marks.Length-1)
            {
                avg = sum / marks.Length;
                if (avg >= 9.5)
                {
                    Console.WriteLine(cont);
                }
                else
                {
                    temp = marks.Length;
                    while (avg < 9.5)
                    {
                        sum += 10;
                        cont++;
                        temp++;
                        avg = sum / temp;
                    }
                    Console.WriteLine(cont);
                }
            }
        }
        
    }
}
