//Victor Tebar
//Challenge 20 Snake

/*
Ejemplo de entrada

4
3 3
3 4
5 3
9 9

Ejemplo de salida

Caso 1
###
..#
###
Caso 2
####
...#
####
Caso 3
###
..#
###
#..
###
Caso 4
#########
........#
#########
#........
#########
........#
#########
#........
#########
*/

#include <iostream>
#include <string>

using namespace std;

int main()
{
    int numTimes,numRows,sizeRows;
    
    cin >> numTimes;
    
    for(int i=0;i < numTimes;i++)
    {
        cin >> numRows >> sizeRows;
        
        cout << "Caso " << i+1 << endl;  // This line was missing
        
        for(int i=1;i<=numRows;i++)
        {
            string row = "";
            string aux = "";
            if(i%2 != 0)
            {
                row.assign(sizeRows,'#');
            }
            else if(i%4 == 0)
            {
                row += '#';
                aux.assign(sizeRows-1,'.');
                row += aux;
            }
            else
            {
                row.assign(sizeRows-1,'.');
                row += '#';
            }
            
            cout << row << endl;
        }
    }
}
