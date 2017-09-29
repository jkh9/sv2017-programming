/*
* Acepta 217, Qué lado de la calle?
* (c) Javier Saorín Vidal
*/

#include <iostream>
using namespace std;

int main()
{
    int number;
    
    cin >> number;
    
    while ( number != 0 )
    {
        if (number % 2 == 0)
            cout << "DERECHA" << endl;
        else
            cout << "IZQUIERDA" << endl;
            
        cin >> number;
    }
    
    return 0;
}
