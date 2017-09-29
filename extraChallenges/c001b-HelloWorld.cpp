/*Guillermo Pastor
*Crea un programa que reciba un entero de la entrada 
* estándar y escriba "Hola mundo." tantas veces como indique ese número.

Entrada de ejemplo

3

Salida de ejemplo

Hola mundo.
Hola mundo.
Hola mundo.

(Acepta el reto 116)
*/

#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    
    while (n > 0)
    {
        cout << "Hola mundo." << endl;
        n = n - 1;
    }
        
    return 0;
}
