/*
Challenge 027:

¿Es día de Navidad?
 
Entrada de ejemplo

2
25 12
03 05

Salida de ejemplo

SI
NO
*/

// Nacho

#include <iostream>
using namespace std;

int main()
{
    int cases, i, day, month;
    cin >>  cases;
    for ( i = 0; i < cases; i++)
    {
        cin >> day;
        cin >> month;
        if ((day == 25) && (month == 12))
            cout << "SI" << endl;
        else
            cout << "NO" << endl;
    }
        
    return 0;
}
