/* 

Challenge 055 : I'm getting married

Sample input
4
100 200 100 200
2
50 25
0

Sample output
600
75

*/

#include <stdio.h>

int main()
{
    int casos;
    int suma;
    int datos;
    
    do
    {
        scanf("%d", &casos);
        if(datos > 0)
        {
            suma = 0;
            for(int i = 0; i < casos ; i++)
            {
                scanf("%d", &datos);
                suma += datos;
            }
            printf("%d\n", suma);
        }
    } while(casos > 0);
    
    return 0;
}
