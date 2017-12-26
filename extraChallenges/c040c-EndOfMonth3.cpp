/*

Are going to get to the end of the month with any savings?

Entrada de ejemplo
7
100 -10
-10 -100
-10 100
100 -1000
2500 -2490
9500 -9500
-100 99

Salida de ejemplo
SI
NO
SI
NO
SI
SI
NO
*/

//Almudena Lopez Sanchez
#include<iostream>
using namespace std;
int main()
{
    int num;
    cin >> num;
    int ingresos;
    int gastos;
    for(int i=0 ; i < num; i++)
    {
        cin >> ingresos;
        cin >> gastos;
        ingresos += gastos;
        if(ingresos < 0)
            cout << "NO" << endl;
        else
            cout << "SI" << endl;
    }
}
