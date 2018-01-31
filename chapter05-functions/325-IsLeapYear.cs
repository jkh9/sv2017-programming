/*
Create a function “IsLeapYear”, to return true if the year indicated as 
parameter is a leap year (a multiple of 4, but not multiple of 100, unless it 
is multiple of 400). It must be used like this:

if (IsLeapYear(1984))
    System.Console.WriteLine('1984 was a leap year');
*/

//Moisés Encinas Picazo

class Program
{
    static void Main()
    {
        if (IsLeapYear(1984))
            System.Console.WriteLine("1984 was a leap year");
    }

    static bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }
        
        if (year % 4 == 0 && year % 100 != 0)
        {
            return true;
        }
        
        return false;
    }
}
