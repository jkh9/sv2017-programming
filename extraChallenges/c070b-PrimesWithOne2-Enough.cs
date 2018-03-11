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

public class Challenge070
{
    
    public static void Main()
    {
        bool measuringTimes = true;
        DateTime start = DateTime.Now;
        
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            int data = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( PrimesStartingWithOneUnder(data));
            
            if (measuringTimes)
            {
                Console.WriteLine(" (" + (DateTime.Now - start) +")");
            }
        }
    }
    
    public static int PrimesStartingWithOneUnder(int n)
    {
        int count = 0;
        for (int i = 11; i <= n; i++)
            if (StartsWith1(i) && IsPrime(i))
                count ++;
        return count;
    }
    
    public static bool StartsWith1(int n)
    {
        return n.ToString()[0] == '1';
    }
    
    public static bool IsPrime(int n)
    {
        if (n % 2 == 0)
        {
            return false;
        }
            
        int max = (int) Math.Sqrt(n);
        for (int i = 3; i <= max; i+=2)
            if (n % i == 0)
            {
                return false;
            }
        return true;
    }
    
}
