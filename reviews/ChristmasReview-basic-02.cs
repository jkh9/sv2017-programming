// Christmas Review - Basic 01
/*

Crea un programa que pregunte al usuario dos palabras y cuántas veces líneas se 
deben mostrar en pantalla alternándolas. Deberá escribir ambas palabras varias 
veces, cada una en una línea, hasta llegar al total indicado por el usuario. 
Por ejemplo:

Dime una palabra: DAM
Dime otra palabra: 2018
Cuantas líneas totales quieres? 3
DAM
2018
DAM
 
Tras cada 20 líneas, deberá hacerse una pausa (esperar hasta que el 
usuario pulse Intro) 
*/

//Marcos Cervantes Matamoros
//Basico 26 de diciembre
using System;
public class Basico26Diciembre
{

    public static void Main()
    {
        bool alternar = true;
       Console.Write("Dime una palabra: ");
       string pala1 = Console.ReadLine();
       
       Console.Write("Dime otra palabra: ");
       string pala2 = Console.ReadLine();
       
       Console.Write("Cuantas lineas totales quieres? ");
       int lineas = Convert.ToInt32(Console.ReadLine());
       
       for(int i = 1; i <= lineas; i++)
       {
            if(alternar)
            {
                Console.WriteLine(pala1);
                alternar = false;
            }
            else
            {
                Console.WriteLine(pala2);
                alternar = true;
            }
                
            if(i % 20 == 0)
            {
                Console.Write("Pulsa intro para continuar");
                Console.ReadLine();
            }
       }
    }
}
