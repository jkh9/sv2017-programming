//Almundena Lopez Sanchez

using System;

public class Ex1
{
    
    public static bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }
        if (year % 4 == 0 && year % 100 != 100)
        {
            return true;
        }
        return false;
    }

    public static void CountVS(string text, ref int amountOfVowels, ref int amountOfSpaces)
    {
        amountOfVowels = 0;
        amountOfSpaces = 0;

        text = text.ToLower();
        foreach (char n in text)
        {
            if (n == ' ')
                amountOfSpaces++;
            else if (n == 'a' || n == 'e' || n == 'i' ||
                n == 'o' || n == 'u')
                amountOfVowels++;
        }
    }

    public static void WriteTriangleOfName(string name, int num)
    {
        int rows = name.Length < num ? name.Length : num;

        int spaces = rows - 1;
        int letters = 1;

        for(int r = 0; r < rows; r++)
        {
            for (int sp = 0; sp < spaces; sp++)
                Console.Write(" ");
            Console.WriteLine(name.Substring(name.Length-letters));
            Console.WriteLine();
            spaces--;
            letters++;
        }
    }

    public static void WritePowers3(int num)
    {
        for (int i = num; i >= 0; i--)
            Console.Write("{0} ", Math.Pow(3, i));
    }

    public static void WritePowers3r(int num)
    {
        if (num == 0)
            Console.Write("1 ");
        else
        {
            Console.Write("{0} ", Math.Pow(3, num));
            WritePowers3r(num - 1);
        }
    }

    public static int Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: leap / count / triangle / power");
            return 1;
        }
        else
        {
            switch(args[0].ToLower())
            {
                case "leap":
                    if (args.Length == 2)
                        try
                        {
                            if (IsLeapYear(Convert.ToInt32(args[1])))
                                Console.WriteLine("A leap year");
                            else
                                Console.WriteLine("It was not a leap year");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Only numbers, please!");
                            return 2;
                        }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                        
                    break;
                case "count":
                
                    if (args.Length == 2)
                    {
                        int amountOfVowels = 0;
                        int amountOfSpaces = 0;
                        //Para que te coja la frase entera tienes que ponerle " " 
                        //si no se piensa que cada palabra es un argumento
                        CountVS(args[1], ref amountOfVowels, ref amountOfSpaces);
                        Console.WriteLine("Vowels: " + amountOfVowels);
                        Console.WriteLine("Spaces: " + amountOfSpaces);
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;
                case "triangle":
                    if(args.Length == 3)
                    {
                        try
                        {
                            WriteTriangleOfName(args[1], Convert.ToInt32(args[2]));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Size must be a number");
                            return 2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;
                    
                case "power":
                    if (args.Length == 2)
                    {
                        WritePowers3(Convert.ToInt32(args[1]));
                        Console.WriteLine();
                        WritePowers3r(Convert.ToInt32(args[1]));
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;

                default:
                    Console.WriteLine("Usage: leap / count / triangle / power");
                    return 1;

            }
            return 0;
        }
    }
}
