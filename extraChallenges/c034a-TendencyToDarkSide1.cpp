/*

Acepta 428: Tendencia al lado oscuro

Sample input
5
27
24
4
234
4444
Sample output
NO
SI
NO
SI
NO

*/

// Guillermo Pastor

#include <iostream>
using namespace std;

int main()
{
    int cases;
    cin >> cases;

    for(int c = 0; c < cases; c++)
    {
        string darkness = "";
        int midi;
        cin >> midi;
        
        while(midi > 0)
        {
            int mod = midi % 5;
            char cMod = (char)(mod) +'0';
            darkness = cMod + darkness;
            midi /= 5;
        }
        int darkCount = 0;
        
        for(unsigned int d = 0; d < darkness.length(); d++)
        {
            if(darkness[d] == '4')
            {
                darkCount++;
            }
        }
        
        if(darkCount > 1)
            cout << "SI" << endl;
        else
            cout << "NO" << endl;
    }
    return 0;
}
