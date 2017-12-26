// Christmas Review - Basic 01
/*
Crea un programa que pregunte al usuario su nombre y cuántas veces desea verlo 
escrito. Deberá escribir el nombre tantas veces como haya indicado el usuario, 
cada una en una línea. En las líneas impares, el nombre se mostrará tal cual; 
en las pares se mostrará precedido por fos guiones y seguido por otros dos 
guiones. Por ejemplo:

Dime tu nombre: Juan
Cuantas veces quieres que lo escriba? 3
Juan
--Juan--
Juan
*/

//Marcos Cervantes Matamoros
//Basico 24 de diciembre
using System;
public class Basico24Diciembre
{
    public static void WriteOdd(string name)
    {
        Console.WriteLine(name);
    }
    
    public static void WriteEven(string name)
    {
        Console.WriteLine("--{0}--",name);
    }
    
    public static void Main()
    {
        bool odd = true;
        Console.Write("Write your name: ");
        string name = Console.ReadLine();
        
        Console.Write("How many times do you want repeat your name? ");
        int repeat = Convert.ToInt32(Console.ReadLine());
       
        for(int i = 0; i < repeat; i++)
        {
            if(odd)
            {
                WriteOdd(name);
                odd = false;
            }
        
            else
            {
                WriteEven(name);
                odd = true;
            }
        }
    }
}
