/*
Las bicicletas tienen varios platos y varias coronas y el ciclista debe decidir 
en cada momento qué combinación utiliza. Cuando se comienza una cuesta arriba, 
por ejemplo, normalmente se va haciendo descender la relación, lo que da la 
sensación de que la bicicleta "pesa menos".

Para una serie de tamaños de plato y de corona, deberás hallar la relación que 
existe entre los dientes que tienen ambos, para mostrar estas relaciones 
ordenadas de menor a mayor desarrollo:

Entrada de ejemplo

2 3
34 48
20 26 34
1 4
44
28 24 20 16
0 0

Salida de ejemplo

34-34 34-26 48-34 34-20 48-26 48-20
44-28 44-24 44-20 44-16
*/

// Victor Tebar

#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

struct Wheel{
    int plate;
    int crown;
    float ratio;
};

bool sortByRatio(const Wheel &w1, const Wheel &w2) { return w1.ratio < w2.ratio; }

int main(){
    int numPlates,numCrowns,totalComb;
    int* plates;
    int* crowns;
    
    do{
        cin >> numPlates >> numCrowns;
        if(numPlates != 0 && numCrowns != 0){
            plates = new int[numPlates];
            crowns = new int[numCrowns];
            totalComb = numPlates * numCrowns;
            Wheel wheel[totalComb];
            
            for(int i=0;i<numPlates;i++){
                cin >> plates[i];
            }
            
            for(int i=0;i<numCrowns;i++){
                cin >> crowns[i];
            }
            
            int k=0;
            for(int i=0;i< numPlates;i++){
                for(int j=0;j < numCrowns;j++){
                    wheel[k].plate = plates[i];
                    wheel[k].crown = crowns[j];
                    wheel[k].ratio = (float)plates[i]/(float)crowns[j];
                    k++;
                }
            }
            
            sort(wheel,wheel + totalComb,sortByRatio);
            
            for(int i=0;i < totalComb;i++){
                if(i != totalComb - 1)
                    cout << wheel[i].plate << "-" << wheel[i].crown << " ";
                else
                    cout << wheel[i].plate << "-" << wheel[i].crown;
            }
            
            cout << endl;
            delete plates;
            delete crowns;
        }
    }while(numPlates != 0 && numCrowns != 0);
}
