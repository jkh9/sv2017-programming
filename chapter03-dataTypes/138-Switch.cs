// Create a C# program which asks the user for a symbol and answers if it is a 
// lowercase letter (a to z), a digit (0 to 9) a double quote (") or any other 
// symbol.
//
// Do it two times, first with "if" and then with "switch".

//Moisés Encinas Picazo

using System;

public class Ex138
{
    public static void Main()
    {
        Console.Write("Symbol: ");
        char n = Convert.ToChar(Console.ReadLine());
        
        switch (n)
        {
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'o':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
                Console.WriteLine("Lowercase letter");
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("Digit");
                break;
            case '\"':
                Console.WriteLine("\"");
                break;
            default:
                Console.WriteLine("Other symbol");
                break;
        }
        
        if (n >= '0' && n <= '9')
            Console.WriteLine("Digit");
        else if (n >= 'a' && n <= 'z')
            Console.WriteLine("Lowercase letter");
        else if (n == '\"')
            Console.WriteLine("\"");
        else 
            Console.WriteLine("Other symbol");
    }   
}
