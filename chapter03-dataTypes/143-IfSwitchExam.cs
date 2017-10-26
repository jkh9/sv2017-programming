/*
Crea un programa en C# que pida al usuario que introduzca un símbolo, y diga si 
se trata de un paréntesis ("(" y ")"), un corchete ("[" y "]"), una llave ("{" 
y "}"), de una cifra del 0 al 9 o de otro símbolo, de dos formas distintas (2 
puntos):

Usando “case”

Usando “if”
*/

//Daniel MiQuel Sirera

using System;

public class EjercicioEx2
{
	public static void Main()
	{
        char symbol;
        
        Console.WriteLine("Símbolo? ");
        symbol = Convert.ToChar(Console.ReadLine());
        
        if(symbol == '(' || symbol == ')')
            Console.WriteLine("Paréntesis");
        else if(symbol >= '0' && symbol <= '9')
            Console.WriteLine("Número");
        else if(symbol == '[' || symbol == ']')
            Console.WriteLine("Corchete");
        else if(symbol == '{' || symbol == '}')
            Console.WriteLine("Llaves");
        else
            Console.WriteLine("Otro símbolo");
        
        switch(symbol){
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
                Console.WriteLine("Número");
                break;
            case ']':
            case '[': 
                Console.WriteLine("Corchete");
                break;
            case '(': 
            case ')': 
                Console.WriteLine("Paréntesis");
                break;
            case '{': 
            case '}':
                Console.WriteLine("Llaves");
                break;
            default: 
                Console.WriteLine("Otro símbolo");
                break;
        }
    }
}
