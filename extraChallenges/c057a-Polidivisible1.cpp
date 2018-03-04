/*
Es número polidivisible?

Un número es polidivisible si es divisible por su longitud y, 
además, si se le quita el último dígito queda un número que 
es a su vez polidivisible.

Entrada de ejemplo

381654729
102
9876
67

Salida de ejemplo
POLIDIVISIBLE
POLIDIVISIBLE
POLIDIVISIBLE
NO POLIDIVISIBLE
*/

// Victor Tebar

#include <iostream>
#include <cstdlib>
using namespace std;

bool IsPolidivisible(unsigned long long int num,int length){
    for(int i= length;i > 0 ;i--){
        if(num%i != 0)
            return false;
        else
            num /= 10;
    }
    return true;
}

int main(){
    string str;
    
    do{
        getline(cin,str);
        if(str != ""){
            unsigned long long int num = strtoull(str.c_str(),NULL,10);
            
            if(IsPolidivisible(num,str.length()))
                cout << "POLIDIVISIBLE" << endl;
            else
                cout << "NO POLIDIVISIBLE" << endl; 
        }
    }while(str != "");
}
