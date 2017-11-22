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

// Javier Saorín Vidal

using System;

public class ChainedWords
{
    public static void Main()
    {
        string line;
        do
        {
            line = Console.ReadLine();
            bool correctChain = true;
            if (line != "")
            {
                string[] words = line.Split();
                if (words.Length != 1)
                {
                    for (int i = 0; i < words.Length - 1; i++)
                        if (words[i].Substring(words[i].Length - 2, 2) !=
                            words[i + 1].Substring(0, 2))
                            correctChain = false;
                    if (correctChain)
                        Console.WriteLine("SI");
                    else
                        Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("SI");
                }
            }
        }
        while (line != "");
    }
}
