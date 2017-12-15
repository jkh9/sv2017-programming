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

/* Nacho */

#include <stdio.h>

int main()
{
    int cases, i, day, month;
    scanf ("%d" , &cases);
    for ( i = 0; i < v; i++)
    {
        scanf ("%d" , &day);
        scanf ("%d" , &month);
        if ((day == 25) && (month == 12))
            printf ("SI\n");
        else
            printf ("NO\n");
    }
        
    return 0;
}
