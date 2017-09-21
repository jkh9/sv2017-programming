// Celsius to Fahrenheit

using System;

public class CelsiusToFahrenheit
{
    public static void Main()
    {
        int celsius, fahrenheit;
        Console.Write("Hoe many Celsius degrees? ");
        celsius = Convert.ToInt32(Console.ReadLine());
        
        fahrenheit = celsius * 18/10 + 32;
        
        Console.WriteLine("{0} Celsius = {1} Fahrenheit", 
            celsius,fahrenheit);
    }
}

