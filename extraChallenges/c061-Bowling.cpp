/*
Tirando bolos

Entrada de ejemplo

4 2
4 4
3 1
0 0

Salida de ejemplo

4
9
0
*/

// Note about the resolution:
// Sum of an arithmetic progression: 1 + 2 + 3 + 4 + ... + n = n * (n+1) / 2

// Victor Tebar

#include <iostream>

using namespace std;

int main(){
    long long unsigned int numRows,rowHit,totalPins,PinHit,a;
    
    do{
        totalPins = 0;
        PinHit = 0;
        cin >> numRows >> rowHit;
        if(numRows != 0 && rowHit != 0){
            totalPins = numRows * (numRows + 1)/2;
            a = numRows - (rowHit - 1);
            PinHit =  a * (a + 1) / 2;
        
            cout << totalPins - PinHit  << endl;
        }
    }while(numRows != 0 && rowHit != 0);
}
