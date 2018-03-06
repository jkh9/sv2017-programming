/*
Divisores del factorial:

Entrada

La entrada estará compuesta de varios casos de prueba. Cada caso de prueba 
consiste en una línea con dos números positivos, p y n, menores que 2^31, 
siendo p un número primo1. La entrada termina con un caso de prueba donde 
ambos números son negativos; para este último no se generará salida alguna.

Salida

Para cada caso de prueba, el programa escribirá YES si p divide a n! y NO en 
caso contrario. Cada veredicto irá en una línea diferente.

Entrada de ejemplo

2 5
7 500000
7 3
-1 -1

Salida de ejemplo

YES
YES
NO
*/

// Victor Tebar

#include <iostream>

using namespace std;

int main() {
    int div,fact;
    
    do{
        cin >> div >> fact;
        if(div >= 0 && fact >= 0){
            if(fact == 0 && div == 1)
                cout << "YES" << endl;
            else if(div <= fact)
                cout << "YES" << endl;
            else
                cout << "NO" << endl;
        }
    }while(div >= 0 && fact >= 0);
}
