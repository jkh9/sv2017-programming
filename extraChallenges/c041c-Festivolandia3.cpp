// Victor Tebar
// Festivolandia

/*
Los días pares de los meses pares son festivos, y los días impares de los meses 
impares también. El único día impar que es festivo en un mes par es el día de 
navidad, el 25 de diciembre. El resto de días son laborables.

Ejemplo de entrada
6
8 7
25 12
11 1
2 2
14 2
3 2

Ejemplo de salida
LABORABLE
FESTIVO
FESTIVO
FESTIVO
FESTIVO
LABORABLE
*/

#include <iostream>

using namespace std;

int main(){
    int numTimes,day,month;
    cin >> numTimes;
    for(int i=0;i<numTimes;i++){
        cin >> day >> month;
        if((day%2 == 0 && month%2 == 0) 
                || (day%2 != 0 && month%2 != 0) 
                || (day == 25 && month == 12))
            cout << "FESTIVO" << endl;
        else
            cout << "LABORABLE" << endl;
    }
}
