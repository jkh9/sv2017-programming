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

/* Victor Tebar, adapted to C by Nacho */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int IsPolidivisible(unsigned long long int num,int length){
    int i;
    for(i= length;i > 0 ;i--){
        if(num%i != 0)
            return 0;
        else
            num /= 10;
    }
    return 1;
}

int main(){
    char str[20];
    
    while(gets(str)){
        unsigned long long int num = strtoll(str,NULL,10);
        
        if(IsPolidivisible(num,strlen(str)))
            printf("POLIDIVISIBLE\n");
        else
            printf("NO POLIDIVISIBLE\n"); 
    }
    
    return 0;
}
