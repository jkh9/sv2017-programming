//Marcos Cervantes Matamoros
//Basico 31 de diciembre
/*
Crea una función llamada "CadenaRepetitiva", que reciba como parámetros
una letra y un número, y devuelva una cadena formada por esa letra, 
repetida tantas veces como indique el número. 

Crea una función "CambiarLetra", que reciba una cadena, una letra y una 
posición, y devuelva como resultado la misma cadena, pero en la que se haya 
modificado el carácter que hay en esa posición, para dejar en su lugar la letra 
indicada por el usuario. Por ejemplo, CambiarLetra("Hola", 'j', 2) devolvería
como resultado "Hoja". 

Crea también un programa de prueba, que te permita saber si el
funcionamiento de esas funciones es correcto. 
*/

using System;
using System.Text;

public class Basico31Diciembre
{
    public static string CadenaRepetitiva(int numero, char letra)
    {
        string cadena = "";
        for(int i = 0; i < numero; i++)
        {
            cadena += letra;
        }
        return cadena;
    }
    
    public static string CambiarLetra(string palabra, 
        char letra, int posicion)
    {
        StringBuilder cadenaModificable = new StringBuilder(palabra); 
        cadenaModificable[posicion] = letra; 
        string texto = cadenaModificable.ToString();
        return texto;
    }
    
    public static void Main()
    {
        int numero = 5;
        char letra = 'a';
        Console.WriteLine(CadenaRepetitiva(numero, letra));
        Console.WriteLine(CambiarLetra("Hola", 'j', 2));
    }
}
