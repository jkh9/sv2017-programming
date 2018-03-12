/*

Problema D: Escape de videojuegos

ProgramaMe Regional Online Valencia 2017-2018 - CEEDCV (Valencia)

Curiosiencio ha aprendido que el juego es una excelente herramienta de 
aprendizaje. Y uno de los juegos más populares hoy en día son los videojuegos.

Investigando sobre el papel de la mujer en el diseño de videojuegos, se ha 
encontrado con dos pioneras en el diseño de aventuras gráficas: Roberta 
Williams, de la que destaca el diseño de la saga “King Quest” y Jane Jensen, 
famosa por la saga “Gabriel Knight”.Incluso ambas llegaron a trabajar juntas en 
el diseño de “King Quest VI”.

Curiosiencio ha decidido ponerse a jugar a estos clásicos de los videojuegos,
adquiriéndolos de forma legal en gog.com.

Se ha dado cuenta de que en estos juegos, habitualmente, había laberintos donde debías
elegir un camino y en el que si elegías mal morías irremediablemente.

Curiosiencio antes de jugar ha planeado los movimientos a realizar.

Realiza un programa que, dado un punto de inicio, un punto de final y un 
camino, compruebe si los movimientos de Curiosiencio le llevan a la meta, a la 
muerte o le dejan en un punto perdido del laberinto.

Entrada

En primer lugar, un número N indicando cuántos casos de prueba habrá.
- 1 <= N <= 100

Por cada caso de prueba habrá:

- Una línea con el número H indicando el número de habitaciones. Las habitaciones
siempre se numerarán del 1 al H, ambos incluidos.
* 2 <= H <= 40
* Suponemos que Curiosencio comienza siempre en la habitación 1 y la
habitación final a alcanzar es la H.

- Una línea C indicando el número de conexiones entre habitaciones.
* 1 <= C <= 20

- C líneas con 2 enteros A y B (2 habitaciones distintas) que indican que existe
posibilidad de ir de la habitación A a la B (y viceversa).

- Una línea con varios enteros separados por comas (sin espacios) que indican 
los movimientos que quiere realizar Curiosencio para tratar de llegar de la 
habitación 1 a la H. No habrá juegos de prueba donde una vez llegado a la 
habitación H, salga de ella. Dicha línea tendrá como mucho 4000 caracteres.

* Habrá al menos algún paso.
* Por ejemplo “2,3” indica que intenta ir de la habitación inicial, la 1, a la
habitación 2, y tras ello a la habitación 3.

Salida

Por cada caso de prueba se mostrará uno de los siguientes resultados:

- GAMEOVER: en el caso de que Curiosiencio intente ir de una habitación a otra 
que no estén conectada.

- PERDIDO: en el caso de que Curiosencio al finalizar la secuencia no haya 
muerto, pero no haya llegado nunca a la habitación H.

- VICTORIA: en el caso de que Curiosencio al finalizar la secuencia no haya 
muerto y haya llegado a la habitación H.

Ejemplo de entrada
3
2
1
1 2
2
3
1
1 2
2,3
5
2
1 2
3 2
2,3

Ejemplo de salida

VICTORIA
GAMEOVER
PERDIDO

Explicación del ejemplo

En el primer caso de prueba, hay dos habitaciones y una conexión bidireccional 
entre la 1 y la 2. Al intentar ir de la 1 a la 2, se consigue la victoria.

En el segundo caso de prueba, hay tres habitaciones y una conexión 
bidireccional entre la 1 y la 2. Al intentar ir de la 1 a la 2 se puede, pero 
de la 2 a la 3 no hay conexión, por lo que se obtiene GAMEOVER.

En el tercer caso de prueba, hay cinco habitaciones y dos conexiones 
bidireccionales entre la 1 y la 2 y entre la 2 y la 3.

Al intentar ir de la 1 a la 2 se puede, así como ir de la 2 a la 3. Pero al 
acabarse la secuencia y no haber llegado a la 5, se considera PERDIDO.

*/
using System;

public class Challenge071
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            int rooms = Convert.ToInt32(Console.ReadLine());
            bool[,] roomConnections = new bool[rooms, rooms];

            int connections = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < connections; j++)
            {
                string[] connectionData = Console.ReadLine().Split();
                int room1 = Convert.ToInt32(connectionData[0]);
                int room2 = Convert.ToInt32(connectionData[1]);
                roomConnections[room1 - 1, room2 - 1] = true;
                roomConnections[room2 - 1, room1 - 1] = true;
            }

            string[] path = Console.ReadLine().Split(',');
            int lastRoom = Convert.ToInt32(path[path.Length - 1]);
            if (lastRoom != rooms)
            {
                Console.WriteLine("PERDIDO");
            }
            else
            {
                bool brokenPath = false;
                int currentRoom = 1;
                for (int j = 0; j < path.Length; j++)
                {
                    int nextRoom = Convert.ToInt32(path[j]);
                    if (roomConnections[currentRoom - 1, nextRoom - 1] == false)
                    {
                        brokenPath = true;
                        break;
                    }
                    currentRoom = nextRoom;
                }
                if (brokenPath)
                {
                    Console.WriteLine("GAME OVER");
                }
                else
                {
                    Console.WriteLine("VICTORIA");
                }
            }
        }
    }
}
