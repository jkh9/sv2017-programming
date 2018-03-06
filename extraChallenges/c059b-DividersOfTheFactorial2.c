/*
Divisores del factorial:

Entrada

La entrada estará compuesta de varios casos de prueba. Cada caso de prueba 
consiste en una línea con dos números positivos, p y n, menores que 2^31, 
siendo p un número primo1. La entrada termina con un caso de prueba donde 
ambos números son negativos; para este último no se generará salida alguna.

Salida

Para cada caso de prueba, el programa escribirá YES si p divide a n! y NO en 
caso contrario. Cada veredicto irá en una línea diferente.

Entrada de ejemplo

2 5
7 500000
7 3
-1 -1

Salida de ejemplo

YES
YES
NO
*/

// Nacho

#include <stdio.h>
 
int main() 
{
    long int divisor, factorial;
    
    do
    {
        scanf("%ld", &divisor);
        scanf("%ld", &factorial);
        
        if (factorial == 0)
            factorial = 1;

        if ((divisor > 0) || (factorial > 0))
        {
            if (divisor <= factorial)
                puts("YES");
            else
                puts("NO");
        }
        
    }
    while ((divisor > 0) || (factorial > 0));
    return 0;
}
