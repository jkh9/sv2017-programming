/*

Problema C: Ensenando primalidad
ProgramaMe Regional Online Valencia 2017-2018 - CEEDCV (Valencia)
Curiosiencio ha visto que habia grandes mujeres en el mundo de la ciencia y se ha dado
cuenta que tan importante como tener capacidades es recibir una correcta educacion.
Investigando sobre pedagogia, ha encontrado la figura de Maria Montessori. Esta fue
pionera en afirmar y defender teorias que hoy nos parecen evidentes, como que el juego es
la forma natural de aprender que tienen los ninos.
Curiosiencio ha decidido que quiere aprender sobre numeros primos.
Podemos afirmar que un numero primo es aquel numero que solo es divisible por si mismo
y por la unidad y que el numero 1 no se considera primo.
Para aprender a calcularlos, Curiosiencio ha pensado convertirlo en un juego: dado un
numero X, debe decir cuantos numeros menores o iguales a X son primos y ademas
empiezan por 1.
Entrada
En primer lugar, un numero N indicando cuantos casos de prueba habra.
 1 <= N <= 100
Por cada caso de prueba, una linea con el numero X.
 1 <= X <= 2000000
Salida
Se mostraran N lineas, una por cada caso de prueba, donde se indicara el numero de
primos que empiezan por 1 menores o iguales al numero dado.

Ejemplo de entrada
13
100
137
7
1000
10000
100000
1000000
1500000
1600000
1700000
1800000
1900000
2000000


Ejemplo de salida
4
12
0
25
160
1193
9585
45242
52214
59228
66159
73116
80020

Explicacion del ejemplo (3 primeros casos)
Con el numero 100, los primos menores o iguales que empiezan por 1 son:
11, 13, 17, 19
Con el numero 137, los primos menores o iguales que empiezan por 1 son:
11, 13, 17, 19, 101, 103, 107, 109, 113, 127, 131, 137
Con el numero 7, no hay primos menores o iguales que empiezan por 1.
Hay algunos primos (2, 3, 5, 7) pero ninguno comienza por 1.

*/
using System;
using System.Collections;     // Para BitArray
using System.Collections.Generic;  // Para List<>

public class Challenge070
{
    const long MAX = 2000000;
    static Dictionary<int,bool> isPrimeNumber;
    static int[] primesWith1;
    static bool debugging = true;
    
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        bool measuringTimes = true;
        DateTime start = DateTime.Now;
        
        isPrimeNumber = new Dictionary<int,bool>(2000000);
        GenerateListOfPrimes(MAX);
        GenerateListOfPrimesStartingWith1(MAX);
        
        for (int i = 0; i < n; i++)
        {
            int data = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( primesWith1[data] );
            
            if (measuringTimes)
            {
                Console.WriteLine(" (" + (DateTime.Now - start) +")");
            }
        }
    }
    
    public static void GenerateListOfPrimes(long max)  // Sieve of Erasthotenes
    {
        isPrimeNumber[2] = true;
        int maxSquareRoot = (int)(Math.Sqrt(max));
        BitArray discarded = new BitArray((int)(max + 1));

        for (int i = 3; i <= max; i += 2)
            if (!discarded[i])
            {
                isPrimeNumber[i] = true;
                if (i < maxSquareRoot)
                    for (int j = i * i; j <= max; j += 2 * i)
                        discarded[j] = true;
            }
        if (debugging) Console.WriteLine("Sieve finished");
    }
    
    // This function is specific for this challenge
    public static void GenerateListOfPrimesStartingWith1(long max)
    {
        primesWith1 = new int[max+1];
        int foundSoFar = 0;
        
        primesWith1[1] = 0;
        for (int i = 2; i <= max; i ++)
        {
            if (StartsWith1(i) && isPrimeNumber.ContainsKey(i))
                foundSoFar ++;
            primesWith1[i] = foundSoFar;
        }
        if (debugging) Console.WriteLine("All data calculated");
    }
    
    public static bool StartsWith1(int n)
    {
        return n.ToString()[0] == '1';
    }
}
