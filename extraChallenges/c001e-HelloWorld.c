/*
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

#include <stdio.h>

int main()
{
    int n;
    scanf("%d", &n);
    
    while (n > 0)
    {
        printf("Hola mundo.\n");
        n = n - 1;
    }
        
    return 0;
}
