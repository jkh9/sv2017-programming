/*
The Biologist Problem
Solution by: Nacho

Input Two strings of dna nucleotide bases, each representing one genome sequence.

Output A single string - the longest sequence of adjacent nucleotide bases that 
are present in both lifeforms.

Input sample
ctgactga actgagc
cgtaattgcgat cgtacagtagc
ctgggccttgaggaaaactg gtaccagtactgatagt
acgctgggccttgaggaaaactgctgaattc ctgggccttgaggaaaactgctgggccttgaggaaaactgctgggccttgaggaaaactgctgggccttgaggaaaactg

Output sample
actga
cgta
actg
gctgggccttgaggaaaactgctg
*/
using System;
using System.IO;

public class TheBiologistProblem
{
    public static void ProcessAndDumpLine(string line)
    {
        string[] fragmentos = line.Split(new char[] { ' ' });
        string menor, mayor;
        string cadenaMasLarga = "";

        if (fragmentos[0].Length > fragmentos[1].Length)
        {
            menor = fragmentos[1];
            mayor = fragmentos[0];
        }
        else
        {
            menor = fragmentos[0];
            mayor = fragmentos[1];
        }

        for (int longitud = 1; longitud <= menor.Length; longitud++)
            for (int posInicial = 0; posInicial <= menor.Length - longitud; posInicial++)
                if (mayor.Contains(menor.Substring(posInicial, longitud)))
                    cadenaMasLarga = menor.Substring(posInicial, longitud);

        Console.WriteLine(cadenaMasLarga);
    }

    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
        while ((text != null) && (text.Length > 0))
        {
            ProcessAndDumpLine(text);
            text = Console.ReadLine();
        }
    }
}
