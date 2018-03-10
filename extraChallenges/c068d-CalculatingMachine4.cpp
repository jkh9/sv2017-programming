/*
Problema A: Máquina de cálculo


Ejemplo de entrada
5
5 + -13
10 / 2
7 * 3
3 / 0
5 - 13

Ejemplo de salida
-8
5
21
ERROR
-8

*/

#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    
    for (int i = 0; i < n; i++)
    {
        int n1;
        cin >> n1;
        string op;
        cin >> op;
        int n2;
        cin >> n2;
        switch (op[0])
        {
            case '+':
                cout << n1+n2 << endl;
                break;
            case '-':
                cout << n1-n2 << endl;
                break;
            case '*':
                cout << n1*n2 << endl;
                break;
            case '/':
                if (n2 == 0)
                    cout << "ERROR" << endl;
                else
                    cout << n1/n2 << endl;
                break;
        }
    }        
    return 0;
}
