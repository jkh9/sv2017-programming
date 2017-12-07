using System;

public class Ex235
{
    // Exercise 1
    public static int SumDigits(int n)
    {
        int sum = 0;
        foreach (char d in n.ToString())
        {
            sum += Convert.ToInt32(d.ToString());
        }
        return sum;
    }

    // Exercise 2
    public static void DisplayTextBoxed(string text)
    {
        String border = new String('-', text.Length + 4);
        border = "+" + border + "+";
        Console.WriteLine(border);
        Console.WriteLine();
        Console.WriteLine("|  " + text + "  |");
        Console.WriteLine();
        Console.WriteLine(border);
    }

    // Exercise 3
    // Note: this solution fails if n1 = n2 = max
    public static void Get2Max(float[] data, 
        out float max, out float second)
    {
        max = data[0];
        second = data[0];
        foreach (float n in data)
            if (n > max)
                max = n;
        foreach (float n in data)
            if (n < max && n > second)
                second = n;
    }

    // Exercise 4
    // Note: the iterative solution does not use 
    // the expected algorithm, so it is not valid
    public static int AmountOfDigits(int n)
    {
        return n.ToString().Length;
    }

    public static int AmountOfDigitsR(int n)
    {
        if (n < 10)
            return 1;
        return 1 + AmountOfDigitsR(n / 10);
    }


    public static int Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: sum / second / boxed /  digits");
            return 1;
        }
        else
        {
            switch(args[0].ToLower())
            {
                case "sum":
                    if (args.Length <= 2)
                        Console.WriteLine(SumDigits(123));
                    else
                        Console.WriteLine("Missing parameters");
                    break;

                case "boxed":
                    if (args.Length <= 2)
                        DisplayTextBoxed("Hello");
                    else
                        Console.WriteLine("Missing parameters");
                    break;

                case "second":
                    if (args.Length <= 4)
                    { 
                        float max, second;
                        float[] data = { 2, 7.5f, 6, -1, 20, 5 };
                        Get2Max(data, out max, out second);

                        Console.WriteLine("Maximum is " + max + ", second is " + second);
                    }
                    else
                        Console.WriteLine("Missing parameters");
                    break;

                case "digits":
                    if (args.Length <= 2)
                    { 
                        Console.WriteLine(AmountOfDigits(15));
                        Console.WriteLine(AmountOfDigitsR(20));
                    }
                    else
                        Console.WriteLine("Missing parameters");
                    break;

                default:
                    Console.WriteLine("Usage: sum / second / boxed /  digits");
                    break;
            }
            return 0;
        } 
    }
}

