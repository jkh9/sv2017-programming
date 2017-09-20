/*
Create a C# program to ask the user for the amount of "mmHg" and 
display its equivalent using "bars". It must show 3 decimal digits, 
using only integer numbers
*/

// Javier Cases Sempere

public class Ex21
{
    public static void Main()
    {
        int mmHg;
        
        System.Console.Write(
            "Enter a Millimeters of Mercury: ");
        mmHg = System.Convert.ToInt32(
            System.Console.ReadLine());
        
        int milibars = (mmHg * 1000) / 750;
        
        int bars = milibars / 1000;
        int decimals = milibars % 1000;
        
        System.Console.WriteLine(
            "{0}mmHg -> {1},{2}bar", 
            mmHg, bars, decimals);
    }
}
