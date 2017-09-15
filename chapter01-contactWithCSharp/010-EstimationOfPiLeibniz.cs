//Almudena Lopez Sanchez
//Pi approximation
using System;
public class Pi
{
	public static void Main()
	{
		Console.WriteLine("Pi is approximately: ");
		Console.WriteLine((1 - (1 / 3.0) + (1 / 5.0) -
			(1 / 7.0) + (1 / 9.0)) * 4);
	}
}
