/*
Rebotando en el parchís (ch C, 06-Mar)

En el parchís y muchos otros juegos de mesa en los que los jugadores compiten 
por ser los primeros en alcanzar una meta, a menudo es necesario llegar al 
destino de manera exacta. Tras la tirada de dados, si el valor obtenido es más 
del necesario para llegar al destino, la ficha debe rebotar, volviendo hacia 
atrás una vez alcanzada la meta.

A veces, conseguir caer exactamente en la posición final es lo más tedioso, y 
los jugadores ven cómo sus fichas rebotan continuamente en ella sin ser capaces 
de que el azar les deje, por fin, terminar la partida.

Entrada

Cada caso de prueba está compuesto por tres números, indicando la cantidad de 
casillas c del tablero de la variante del parchís a la que se está jugando, la 
posición p en la que está la ficha del jugador, y el número t obtenido en la 
última tirada de dados. La primera posición del tablero es la 1, la última es 
la meta, y se garantiza que 1 <= p,t < c <= 10.000.

Un caso con todos los números a 0 marca el final.

Salida

Para cada caso de prueba, el programa escribirá la posición final de la ficha 
en el tablero tras la tirada.

Entrada de ejemplo

100 99 1
100 99 2
900 800 300
0 0 0

Salida de ejemplo

100
99
700


https://www.aceptaelreto.com/problem/statement.php?id=407
*/

// Víctor Tebar

#include <iostream>

using namespace std;

int main(){
    int boxes,pos,lastThrow;
    int move = 1;
    do{
        cin >> boxes >> pos >> lastThrow;
        if(boxes != 0 || pos != 0 || lastThrow != 0){
            move = 1;
            for(int i=0;i<lastThrow;i++){
                if(pos == boxes || pos < 1)
                    move = -move;
                pos += move;
            }
            cout << pos << endl;
        }
    }while(boxes != 0 || pos != 0 || lastThrow != 0);
}
