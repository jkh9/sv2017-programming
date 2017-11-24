using System;

class Ex203
{
    static int Reverse(int a)
    {
        string reversed = "";
        string x = Convert.ToString(a);
        foreach (char item in x)
        {
            reversed = item + reversed;
        }
        return Convert.ToInt32(reversed);
    }

    static void Main()
    {
        Console.WriteLine(Reverse(231));
    }
}
