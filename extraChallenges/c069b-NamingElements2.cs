/*

Problema B: Nombrando elementos
ProgramaMe Regional Online Valencia 2017-2018 - CEEDCV (Valencia)
Curiosiencio esta fascinado por el mundo la ciencia y la tecnologia y pasando de enlace en
enlace ha descubierto que uno de los cientificos con mas exito de la historia es Marie Curie,
una cientifica de origen polaco y nacionalidad francesa.
Entre sus muchos logros (incluyendo dos premios Nobel, siendo la primera mujer en la
historia en ganar un premio de este tipo) destaca su descubrimiento de dos nuevos
elementos quimicos en 1898: el Polonio (nombrado asi por Marie en honor a su pais) y el
Radio. En 1903 recibe el premio Nobel de Fisica por el descubrimiento de dichos elementos
radiactivos.
Curiosiencio ha decidido imaginarse como ser un gran investigador y como elegiria los
nombres. Esta pensando que solo le valdrian nombres cuyas consonantes no estuvieran en
orden alfabetico. En esa definicion encajarian nombres como Polonio y Radio, sin embargo
no Helio.
Entrada
En primer lugar, un numero N indicando cuantos casos de prueba habra.
 1 <= N <= 10000
Habra una linea por cada caso de prueba. Cada una de esas lineas constara de una
cadena sin espacios que indica el nombre a comprobar. Dicha cadena unicamente podra
contener letras mayusculas y minusculas y tendra un tamano maximo de 1000 caracteres.
Se garantiza que cada palabra tendra al menos una consonante.
Salida
Se mostraran N lineas, una por cada caso de prueba, donde se indicara OK en el caso de
que las consonantes no esten presentes en orden alfabetico ascendente o ERROR en caso
contrario.
Ejemplo de entrada
6
Polonio
TT
RADIO
helio
BeCeRRo
AHA
Ejemplo de salida
OK
ERROR
OK
ERROR
ERROR
ERROR
Explicacion del ejemplo
"Polonio" tiene como consonantes "P", "l" y "n". "P" va despues que "l", por lo cual no estan
en orden alfabetico ascendente.
"TT" tiene como consonantes "T" y "T". Al ser iguales, se puede considerar que van en
orden alfabetico ascendente, por lo cual es un error.
"RADIO" tiene "R" y "D", siendo "R" posterior a "D", por lo cual no estan en orden alfabetico
ascendente.
"helio" tiene "h" y "l", "h" va antes que "l", por lo cual si estan en orden alfabetico
ascendente.
"BeCeRRo" tiene "B", tras ello "C" y finalmente dos "RR", por lo cual se considera que esta
en orden alfabetico ascendente.
"AHA" solo tiene una consonante, por lo cual se considera que esta en orden alfabetico
ascendente.

*/
using System;

public class Challenge069
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine();
            
            word = word.ToUpper();
            word = word.Replace("A", "");
            word = word.Replace("E", "");
            word = word.Replace("I", "");
            word = word.Replace("O", "");
            word = word.Replace("U", "");
            
            char[] letters = word.ToCharArray();
            Array.Sort(letters);
            string sortedWord = new string(letters);
            
            if (word == sortedWord)
                Console.WriteLine("ERROR");
            else
                Console.WriteLine("OK");
        }
    }
}
