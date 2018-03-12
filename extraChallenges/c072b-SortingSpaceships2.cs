/*

Problema E: Ordenando naves espaciales

ProgramaMe Regional Online Valencia 2017-2018 - CEEDCV (Valencia)

Curiosiencio se ha dado cuenta que los videojuegos le permiten llegar a otros 
mundos y eso le ha hecho reflexionar ¿Ha podido la ciencia llevar a gente a 
otros mundos, pero de verdad?

Investigando ha encontrado la figura de Katherine Johnson. Katherine fue una 
reputada astrofísica y matemática que entre un gran legado relacionado con todo 
el mundo del espacio destaca su trabajo en la NASA, realizando manualmente 
cálculos de diversas trayectorias de vuelos espaciales (entre ellos Apolo XI y 
XIII), así como usando computadoras para verificar sus cálculos, haciendo por 
demostrar la confianza en ellas.

Curiosiencio reflexiona sobre el cálculo de órbitas y piensa que para ello es 
muy importante saber el peso (y cuanto menos, mejor). Con eso se plantea el 
siguiente problema: Curiosiencio piensa que cada nave espacial debe llevar un 
mínimo de oxígeno para que sus tripulantes puedan vivir.

Entonces quiere ordenar una serie de naves para saber si son aptas (superan el 
límite de oxígeno) o no. En ese caso realizaremos una ordenación entre aquellos 
que superan o igualan el nivel de oxígeno (que irán primero) y aquellos que no.

A su vez, una vez separado en estos dos grupos, queremos ordenar cada uno de 
estos grupo por menor peso total. Y en el caso de empate entre dos cantidades 
iguales de peso total, por la mayor cantidad de oxígeno.

Entrada

En primer lugar, un número N indicando cuántos casos de prueba habrá.
- 1 <= N <= 3
Por cada caso de prueba habrá:
- Una línea con un numéro O indicando el mínimo de oxígeno para vivir.
* 1 <= O <= 100000
- Una línea con el número C indicando cuantas naves habrá.
* 1 <= C<= 50000
- C líneas, cada una con dos enteros, indicando cantidad de oxígeno y peso total.
* 1 <= OT <= 100000 y 1 <= P <= 100000

Salida

Por cada caso de prueba se mostrará la línea “Caso x:” donde x es el número de 
caso de prueba, y a continuación la lista ordenada de naves de ese caso de 
prueba.

Ejemplo de entrada

2
100
3
100 1000
50 300
50 5000
200
3
100 1000
60 300
50 300

Ejemplo de salida

Caso 1:
100 1000
50 300
50 5000
Caso 2:
60 300
50 300
100 1000

Explicación del ejemplo

En el primer caso de prueba, sólo iguala el umbral “100 1000” (el umbral es 
100), por lo cual va primero. “50 300” y “50 5000” no superan el umbral. Para 
desempatar entre ellos, va primero el de menor peso.

En el segundo caso de prueba ninguno supera el umbral (300). Deben desempatar 
entre todos ellos. Van primero “50 300” y “60 300” dado que son los de menor 
peso. Para desempatar entre ellos, se mira cuál tiene mayor cantidad de 
oxígeno. El último es “100 1000” por tener mayor peso.

*/
using System;

public class Challenge072
{
    public static int MinOxygen;
    
    public struct Ship : IComparable
    {
        public int oxygen;
        public int weight;
        
        public int CompareTo(object s2)
        {
            // If the first has enough oxygen and the second has not
            if ((oxygen >= MinOxygen) &&
                    ((Ship)s2).oxygen < MinOxygen)
            {
                return -1;
            }
            else
            // If the second has enough oxygen and the first has not
            if ((oxygen < MinOxygen) &&
                    ((Ship)s2).oxygen >= MinOxygen)
            {
                return 1;
            }
            // If both have either enough or not
            else
            {
                // Sort by weight ascendind
                if (weight < ((Ship)s2).weight) return -1;
                else if (weight > ((Ship)s2).weight) return +1;
                else
                {
                    // And the by oxygen descending
                    if (oxygen > ((Ship)s2).oxygen) return -1;
                    else if (oxygen < ((Ship)s2).oxygen) return +1;
                    else return 0;
                }
            }
        }
    }
    
    static Ship[] data;
    
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            MinOxygen = Convert.ToInt32(Console.ReadLine());
            int ships = Convert.ToInt32(Console.ReadLine());
            data = new Ship[ships];
            for (int s = 0; s < ships; s++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split();
                data[s].oxygen = Convert.ToInt32(parts[0]);
                data[s].weight = Convert.ToInt32(parts[1]);
            }
            
            Console.WriteLine("Caso "+ (i+1) +":");
            Array.Sort(data);
            for (int s = 0; s < ships; s++)
            {
                Console.WriteLine(data[s].oxygen + " "+ 
                    data[s].weight);
            }
        }
    }
}
