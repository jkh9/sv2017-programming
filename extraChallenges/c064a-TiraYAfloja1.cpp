/*

Tira y afloja

El tira y afloja se jugaba mucho en las ferias y fiestas populares. También lo 
jugaban los niños en el patio del colegio, o por las tardes en la plaza. Se 
forman dos equipos, y cada uno se situa a un lado de una línea marcada en el 
suelo sujetando una cuerda. La cuerda se mantiene estirada y a una señal del 
árbitro cada equipo tira de la cuerda hacia su campo. El juego termina cuando 
algún equipo consigue que el contrario suelte la cuerda o que algún oponente 
traspase la línea que separa los dos campos.

En mi colegio se jugaba durante la clase de educación física. La profesora nos 
colocaba en fila y nos daba la cuerda. Para hacer los equipos lo más 
equilibrados posible, marcaba la línea central en el punto en el que el peso de 
los alumnos que quedaban en la parte izquierda era lo más parecido posible al 
peso de los alumnos que quedaban en la parte derecha. Como todos los niños 
sabíamos, para ganar es mucho más importante el peso del equipo que el número 
de jugadores. Había algunos días en los que la línea divisoria se podía colocar 
en varios sitios, siendo la diferencia de peso entre los dos equipos que se 
forman al colocar la línea en un sitio o en otro la misma. Esto ponía a la 
profesora de mal humor y decidía finalizar la clase sin dejarnos jugar.

Entrada

La entrada consta de una serie de casos de prueba. Cada uno de ellos tiene de 
dos líneas. La primera indica el número de alumnos de la clase (entre 2 y 
300.000), y la segunda el peso de cada uno (un número entero entre 1 y 70) 
siguiendo el orden en que están colocados en la fila, de izquierda a derecha. 
Ten en cuenta que la fila no puede reordenarse.

Salida

Para cada caso de prueba se indicará el número de alumnos que quedan en el 
equipo de la izquierda seguido del peso total de dicho equipo y el peso total 
del equipo de la derecha. Si no es posible determinar la posición de la línea 
de forma única, se escribirá "NO JUEGAN".


Entrada de ejemplo

7
45 32 41 37 28 39 32
8
41 43 35 32 31 47 57 62
3
20 25 20

Salida de ejemplo

3 118 136
5 182 166
NO JUEGAN

https://www.aceptaelreto.com/problem/statement.php?id=336
*/

// Víctor Tebar

#include <iostream>
#include <vector>
#include <cstdlib>
#include <cmath>

using namespace std;

int main(){
    int* weights;
    int* singleWeights;
    
    string strKids;
    
    do{
        bool dontPlay = false;
        getline(cin,strKids);
            
        if(strKids != ""){
            int numKids = atoi(strKids.c_str());
            int index = 0;
            int num;
            
            weights = new int[numKids];
            singleWeights = new int[numKids];
            cin >> num;
            weights[0] = num;
            singleWeights[0] = num;
            
            for(int i=1;i < numKids;i++){
                cin >> num;
                weights[i] = num + weights[i - 1];
                singleWeights[i] = num;
            }
            cin.ignore();
            int sum = 0;
            int difference = 2147483646;
            int leftWeight = 0;
            int rightWeight = 0;
            int lastDifference = -1;
            for(int j = numKids - 1;j > 0;j--){
                sum += singleWeights[j];
                if(abs(sum - weights[j - 1]) <= difference){
                    index = j;
                    difference = abs(sum - weights[j - 1]);
                    if(difference == lastDifference)
                        dontPlay = true;
                    lastDifference = difference;
                    leftWeight = weights[j - 1];
                    rightWeight = sum;
                }
            }

            if(dontPlay)
                cout << "NO JUEGAN" << endl;
            else
                cout << index << " " << leftWeight << " " << rightWeight << endl;
            
            delete[] weights;
            delete[] singleWeights;
        }
    }while(strKids != "");
}
