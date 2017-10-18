// Javier Herreros Pozo
// Create a C# program to ask the user for the number of a month.
 
using System;

public class DaysInAMonth
{
    public static void Main()
    {
        int month;
        
        Console.WriteLine("month: ");
        
        do{
        
            month = Convert.ToInt32(Console.ReadLine());
            
        }while(month <= 0 || month >= 13);
        
        if(month == 4 || month == 6 || month == 9 
            || month == 11)
        {   
            Console.WriteLine("The {0}th month has 30 days",month);
        }
        
        else if (month == 2)
        {
            Console.WriteLine("The {0}th month has 28 days",month);
        }
        
        else
        {
            Console.WriteLine("The {0}th month has 31 days",month);
        }
        
        switch(month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 12:
                Console.WriteLine("The {0}th month has 31 days"
                                    ,month); 
            break;
            
            case 4:
            case 6:
            case 9:
            case 11: 
                Console.WriteLine("The {0}th month has 30 days"
                                    ,month); 
            break;
            
            case 2:
                Console.WriteLine("The {0}th month has 28 days"
                                    ,month);
            break;
            
            default: 
                Console.WriteLine("Not a month"); 
            break;
        }
    }
}
