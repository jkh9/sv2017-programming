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

// Victor Tebar

#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

bool Compare(const int &n1,const int &n2){
    return n1 > n2;
}

int main(){
    int numHangars,numShips;
    vector<int> ships;
    vector<int> hangars;
    bool fill;
    do{
        cin >> numHangars;
        fill = true;
        if(numHangars != 0){
            for(int i=0;i < numHangars;i++){
                int h;
                cin >> h;
                hangars.push_back(h);
            }
            
            cin >> numShips;
            
            for(int i=0;i < numShips;i++){
                int s;
                cin >> s;
                ships.push_back(s);
            }
            
            for(int i=0;i < numShips;i++){
                sort(hangars.begin(),hangars.end(),Compare);
                hangars[0] = hangars[0] - ships[i];
                //cout << hangars[0] << endl;
            }
            
            for(int i=0; i < numHangars;i++){
                if(hangars[i] < 0){
                    fill = false;
                    break;
                }
            }
            
            if(fill)
                cout << "SI" << endl;
            else
                cout << "NO" << endl;
                
            hangars.clear();
            ships.clear();
        }
    }while(numHangars != 0);
}
