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

//Almudena López Sánchez

using System;
using System.Collections.Generic;

public class Marks10
{
    public static int CountTo10(List<int> marks,int count)
    {
        double sum = 0;
        foreach (int m in marks)
            sum += m;

        double result = sum / marks.Count;

        //Final case
        if (result >= 9.5)
            return count;
        //Generic case
        marks.Add(10);
        return CountTo10(marks, count+1);
    }

    public static void Main()
    {
        string input = Console.ReadLine();
        string[] marks = input.Split(',');
        List<int> marksList = new List<int>();

        foreach(string m in marks)
            marksList.Add(Convert.ToInt32(m));

        Console.WriteLine(CountTo10(marksList,0));
    }
}
