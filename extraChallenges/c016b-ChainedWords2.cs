/*
Palabras encadenadas:

Entrada de ejemplo

gugutata
mata tapa papa pato
seto taco coma matute
sien encima mapa patuco comida
cata tasama malote tejaba batama
kiosko comida

Salida de ejemplo

SI
SI
NO
SI
SI
NO
*/

//Almudena Lopez Sanchez
//Challenge 16
using System;
public class Challenge16
{
    public static void Main()
    {
        string text = Console.ReadLine();
        while (text != "")
        {
            string [] words = text.Split();
            bool correct = true;
            string syllable= "",finalSyllable = "";
            int position;
            for(int i = 0; i < words.Length-1; i++)
            {
                position = words[i].Length-1;
                finalSyllable = words[i].Substring(position-1,2);
                
                if (i != words.Length-1)
                    syllable = words[i+1].Substring(0,2);
                    
                if(finalSyllable != syllable)
                    correct = false;
            }
            Console.WriteLine(!correct ? "NO" : "SI");
            text = Console.ReadLine();
        }
    }
}
