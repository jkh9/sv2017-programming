// Miguel Puerta
// vowel, digit or other symbol?

using System;

public class Ex107
{
    public static void Main()
    {
        char l;
        
        Console.Write("Letter? ");
        l = Convert.ToChar(Console.ReadLine());
        
        if ( l == 'a' || l == 'A' ||
                l == 'e' || l == 'E' ||
                l == 'i' || l == 'I' ||
                l == 'o' || l == 'O' ||
                l == 'u' || l == 'U')
            Console.WriteLine("{0} is a vowel", l);
        else if ( l >= '0' && l <= '9' )
            Console.WriteLine("{0} is a digit", l);
        else
            Console.WriteLine("{0} is another symbol", l);
            
        switch ( l )
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U': 
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u': 
                Console.WriteLine("{0} is a vowel", l);
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
                Console.WriteLine("{0} is a digit", l);
                break;
            default :   
                Console.WriteLine("{0} is another symbol", l);
                break;
        }
    }
}
