/*
Palabras pentavocálicas

Entrada de ejemplo
4
albaricoque
seculariza
peliagudo
abracadabra

Salida de ejemplo
SI
NO
SI
NO
*/
// Javier Saorín Vidal

using System;

public class Ch019
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            string word = Console.ReadLine();
            if (word.Contains("a") && word.Contains("e") &&
                word.Contains("i") && word.Contains("o") &&
                word.Contains("u"))
                Console.WriteLine("SI");
            else
                Console.WriteLine("NO");
        }
    }
}
