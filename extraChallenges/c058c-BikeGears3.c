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

/* Victor Tebar, adapted to C by Nacho */

#include <stdio.h>
#include <stdlib.h> /* Para qsort */

struct Wheel{
    int plate;
    int crown;
    float ratio;
};

int sortByRatio(const void * datoA, const void * datoB)
{
    struct Wheel* w1 = (struct Wheel*) datoA;
    struct Wheel* w2 = (struct Wheel*) datoB;
    if ( w1->ratio > w2->ratio) return 1;
    else if ( w1->ratio < w2->ratio) return -1;
    else return 0;
}

int main(){
    int numPlates,numCrowns,totalComb;
    int i,j;
    
    do{
        scanf("%d", &numPlates);
        scanf("%d", &numCrowns);
        if(numPlates != 0 && numCrowns != 0){
            int plates[numPlates];
            int crowns[numCrowns];

            totalComb = numPlates * numCrowns;
            struct Wheel wheel[totalComb];
            
            for(i=0;i<numPlates;i++){
                scanf("%d", &plates[i]);
            }
            
            for(i=0;i<numCrowns;i++){
                scanf("%d", &crowns[i]);
            }
            
            int k=0;
            for(i=0;i< numPlates;i++){
                for(j=0;j < numCrowns;j++){
                    wheel[k].plate = plates[i];
                    wheel[k].crown = crowns[j];
                    wheel[k].ratio = (float)plates[i]/(float)crowns[j];
                    k++;
                }
            }
            
            qsort (wheel, totalComb, sizeof(struct Wheel), sortByRatio);
            
            for(i=0;i < totalComb-1;i++){
                printf("%d-%d ", wheel[i].plate, wheel[i].crown);
            }
            printf("%d-%d\n", wheel[i].plate, wheel[i].crown);
        }
    }while(numPlates != 0 && numCrowns != 0);
    
    return 0;
}
