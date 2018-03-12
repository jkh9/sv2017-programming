/*

Problema F: Textos extraños

ProgramaMe Regional Online Valencia 2017-2018 - CEEDCV (Valencia)

Curiosiencio, tras investigar sobre el espacio, descubrió que muchísimas 
mujeres habían contribuido de manera destacable en la carrera espacial, tantas 
que no habría espacio para comentarlas.

A Curiosiencio le llamó la atención Margaret Hamilton, que entre otras muchas 
contribuciones trabajó en el software de vuelo de las misiones Apolo y en el 
diseño de la estación espacial Skylab.

Viendo la simpática fotografía de Margaret, Curiosiencio se ha fijado que en la 
pizarra de la derecha hay secuencias de letras e imaginando, ha pensado que 
podrían ser mensajes extraterrestres usando cifrado César.

El cifrado César es un tipo de cifrado por sustitución en el que una letra en 
el texto original es reemplazada por otra letra que se encuentra un número fijo 
de posiciones más adelante en el alfabeto.

Con ello se ha planteado el siguiente problema. Si alguien le da un alfabeto, 
formado únicamente por vocales y/o consonantes… y una palabra que usa las 
letras de dicho alfabeto ¿Podría cifrar esa palabra en todos los 
desplazamientos posibles de cifrado César?

Entrada

En primer lugar, un número N indicando cuántos casos de prueba habrá.
- 1 <= N <= 100
Por cada caso de prueba habrá:
- Una línea con L letras diferentes del alfabeto en mayúsculas.
* 2 <= L <= 28
- Una línea con una palabra en mayúsculas formada por letras del alfabeto anterior.
Sobre esa palabra se deben generar todos los cifrados con desplazamiento a la
derecha posibles (Es decir, se harán L-1 cifrados).
- Dicha palabra tendrá un tamaño T 1 <= T <= 1000
Salida
Por cada caso de prueba se mostrarán L-1 líneas con los L-1 resultados de cifrar la palabra
con cifrado César posibles (desplazamiento derecha 1, 2… L-1) en orden ascendente
(primero cifrado con desplazamiento 1, luego cifrado con desplazamiento 2, etc…).

Ejemplo de entrada

2
ABCD
ABAD
CB
B

Ejemplo de salida

BCBA
CDCB
DADC
C

Explicación del ejemplo

En el primer caso de prueba (con alfabeto “ABCD”), en primer lugar ciframos 
“ABAD” con desplazamiento 1 a la derecha, resultando en “BCBA”. (Es decir, la A 
se ha convertido en B, la B en C y la D en A).

“ABAD” cifrada con desplazamiento 2 a la derecha es “CDCB”. “ABAD” cifrado con
desplazamiento 3 a la derecha es “DADC”.

En el segundo caso de prueba (con alfabeto “BC”), la cadena “B” con 
desplazamiento 1 a la derecha es “C”.

*/
using System;

public class Challenge073
{
    
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            string alphabet = Console.ReadLine();
            string word = Console.ReadLine();
            
            for (int rotation = 0; rotation < alphabet.Length-1 ; rotation++)
            {
                string result = "";
                for (int pos = 0; pos < word.Length; pos++)
                {
                    result += NextChar( word[pos], alphabet);
                }
                word = result;
                Console.WriteLine(word);
            }
        }
    }
    
    public static char NextChar(char c, string alphabet)
    {
        for (int i = 0; i < alphabet.Length-1; i++)
        {
            if (c == alphabet[i])
                return alphabet[i+1];
        }
        return alphabet[0];
    }
}
