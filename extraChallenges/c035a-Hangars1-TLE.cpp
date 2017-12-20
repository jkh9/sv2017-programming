// Acepta 429: Orgnizando los hangares
// (Cada nave va al hangar más grande posible)

/*
Entrada de ejemplo
 
2
12 20
3
10 11 10
2
12 20
3
10 10 11
3
20 5 10
5
14 3 4 6 5
0

Salida de ejemplo

SI
NO
SI
*/

// Jose Vilaplana, correcciones por Nacho
// Aun así... da error TLE (Time Limit Exceeded)

#include <iostream>
    using namespace std;
    int main()
    {
        int tamanoH, tamanoN;
        
        cin >> tamanoH;
        
        bool caben;
        while(tamanoH != 0)
        {
            int hangares [tamanoH];
            
            caben = false;
            // Leo datos de hangares
            for (int i = 0; i < tamanoH; i++)
                cin >> hangares[i];
            
            // Leo datos de naves
            cin >> tamanoN;
            int naves[tamanoN]; 
            for (int i = 0; i < tamanoN; i++)
            {
                cin >> naves[i];
            }
            
            caben = true;
            // Para cada nave...
            for(int i = 0; i < tamanoN; i++)
            {
                // Busco el hangar más grande
                int posMax = 0;
                for (int j = 0; j < tamanoH; j++)
                {   
                    if (hangares[j] > hangares[posMax])
                    {
                        posMax = j;    
                        cout << hangares[j] << endl;
                    }
                }
                
                if (naves[i] <= hangares[posMax])
                {
                    hangares[posMax] -= naves[i];
                }
                else
                {
                    caben = false;
                    break; // ;-)
                }

            }   
            if (caben)
                cout << "SI" << endl;
            else
                cout << "NO" << endl;   
            cin >> tamanoH;         
        } 
    return 0;
}
