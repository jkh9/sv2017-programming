/*
Create a function GetDigits to obtain the amount of integer digits and the most 
significant digit in a real number. It would be used in a very similar  way to:

GetDigits (236.78, integerDigits, mostSignificantDigit);

Console.WriteLine("Integer digits: "+ integerDigits +", MSD: "+ 
mostSignificantDigit); 

It would display " Integer digits: 3, MSD: 2"
*/

//Moisés Encinas Picazo

using System;

public class Ex335
{
    public static void Main()
    {
        int integerDigits, mostSignificantDigit;
        GetDigits(236.78, out integerDigits, 
            out mostSignificantDigit);
        Console.WriteLine("Integer digits: " + integerDigits + 
            ", MSD: " + mostSignificantDigit);
    }

    public static void GetDigits(double number, 
        out int integerDigits,
        out int mostSignificantDigit )
    {
        int intNumber = (int) number;
        string stringNumber = Convert.ToString(intNumber);
        integerDigits = stringNumber.Length;
        
        mostSignificantDigit = Convert.ToInt32( 
            stringNumber.Substring(0,1) );
    }
}
