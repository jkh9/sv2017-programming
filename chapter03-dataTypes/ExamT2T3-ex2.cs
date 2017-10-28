// Examen de los temas 2 y 3, ejercicio2

using System;

public class Ejercicio2
{
	public static void Main()
	{
		string data = Console.ReadLine();
        switch (data)
		{
			case "<":
			case ">":
			case "<=":
			case ">=":
			case "==":
			case "!=":
				Console.WriteLine("Es un comparador");
				break;
			case "+":
			case "-":
			case "*":
			case "/":
			case "%":
				Console.WriteLine("Es un operador aritmético");
				break;
			case "\"":
			case "\'":
				Console.WriteLine("Es un delimitador de texto");
				break;
			default:
				Console.WriteLine("Es otro texto");
				break;
		}
            
		if ((data == "<") || (data == ">") || (data == "<=") || 
				(data == "<=") || (data == "==") || (data == "!="))
			Console.WriteLine("Es un comparador");
        else if ((data == "+") || (data == "-") || (data == "*") || 
				(data == "/") || (data == "%"))
			Console.WriteLine("Es un operador aritmético");
		else if((data == "\'") || (data == "\"")) 
			Console.WriteLine("Es un delimitador de texto");
		else
			Console.WriteLine("Es otro texto");
	}
}
