/*
Entrada de ejemplo
2
2 20
0 10
1 30
15
1
2 50
1 15
0
Salida de ejemplo
450 200
750
*/

// Solución de Víctor Tebar, corrección menor (PE) por Nacho

#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

bool Compare(int n1,int n2){
    return n1 > n2;
}

int main(){
    int numFamilies,familySons, power,kp;
    vector <int> allKids;
    vector <int> kidForce;
    
    do{
        cin >> numFamilies;
        if(numFamilies != 0){
            for(int j=0; j < numFamilies; j++){
                cin >> familySons >> power;
                for(int i=0;i<familySons;i++){
                    cin >> kp;
                    kidForce.push_back(kp);
                }
                sort(kidForce.begin(),kidForce.begin() + kidForce.size(),Compare);
                allKids.push_back(kidForce[0] * power);
                kidForce.clear();
            }
            sort(allKids.begin(),allKids.begin() + allKids.size(),Compare);
            
            cout << allKids[0];
            for(unsigned int i=1; i < allKids.size();i++){
                cout << " " << allKids[i];
            }
            cout << endl;
            allKids.clear();
        }   
    }while(numFamilies != 0);
}
