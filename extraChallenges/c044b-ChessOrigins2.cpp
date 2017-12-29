/*
Chess origins:
- Grains in the first tile
- Value to multiply each step
- Amount of tiles

Sample input
1 1 10
1 2 3
3 2 3
1 2 7
1 0 2
0 1 2
1 2 0
1 2 8
0 0 0

Sample output
10
7
21
127
1
0
0
255
*/

//Almudena Lopez Sanchez

// Nota: falla en el caso 1 0 2 (muestra "2", en vez de "1").

#include <iostream>
using namespace std;

int main()
{
    int granos,valor,casillas;
    do
    {
        cin >> granos;
        cin >> valor;
        cin >> casillas;
        int acum = 0;
        if(granos != 0 || valor != 0 || casillas != 0)
        {
            if (valor == 0 )
            {
                acum = granos * casillas;
            }
            else
            {
                for(int i = 0; i < casillas; i++)
                {
                    acum += granos;
                    granos *= valor;
                }
            }
            
            cout <<  acum << endl;
        }
    }
    while(granos != 0 || valor != 0 || casillas != 0);
}
