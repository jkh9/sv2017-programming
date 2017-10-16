/* 

Create a C# program to ask the user for their name, age, 
their birth year and the population of their country. You 
should optimize the data types to be used.

 */
using System;
public class IntegerDataTypes
{
    public static void Main()
    {
        string name;
        byte age;
        ushort yearBirthday;
        ulong population;
        
        Console.Write("Name? : ");
        name = Console.ReadLine();
        
        Console.Write("Age? : ");
        age = Convert.ToByte(Console.ReadLine());
        
        Console.Write("Birthday year? ");
        yearBirthday = Convert.ToUInt16(Console.ReadLine());
        
        Console.Write("Population of your country: ");
        population = Convert.ToUInt64(Console.ReadLine());
    }
}
