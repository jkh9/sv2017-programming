// Pedro Luis Coloma

using System;

public class NameONumbers
{
    public static void Main()
    {
        int num;
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        switch (num)
        {
            case 1: Console.Write("ONE"); break;
            case 2: Console.Write("TWO"); break;
            case 3: Console.Write("THREE"); break; 
            case 4: Console.Write("FOUR"); break;
            case 5: Console.Write("FIVE"); break;
            default: Console.Write("???"); break;
        }
    }
}
