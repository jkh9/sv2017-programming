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

#include <stdio.h>

int main()
{
    int n;
    scanf("%d",&n);
    
    int i;
    for (i = 0; i < n; i++)
    {
        int n1;
        scanf("%d",&n1);
        char op;
        scanf("%c",&op); // Blank space
        scanf("%c",&op);
        int n2;
        scanf("%d",&n2);
        switch (op)
        {
            case '+':
                printf("%d\n",n1+n2);
                break;
            case '-':
                printf("%d\n",n1-n2);
                break;
            case '*':
                printf("%d\n",n1*n2);
                break;
            case '/':
                if (n2 == 0)
                    printf("ERROR\n");
                else
                    printf("%d\n",n1/n2);
                break;
        }
    }            
        
    return 0;
}
