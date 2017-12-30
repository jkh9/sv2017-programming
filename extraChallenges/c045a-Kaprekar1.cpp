/*
Numbers of Kaprekar:

703 is, because 703^2 = 494209, and 494 + 209 = 703
9^2 = 81, and 8 + 1 = 9.

First number can be 0 (so 1 is valid), but not the second (so 100 is not valid)

Sample input
22222
75
99
100
504
1
0

Sample output
SI
NO
SI
NO
NO
SI
*/

//Victor Tebar
#include <iostream>

using namespace std;

int main(){
    unsigned long long num,numPow,divider,firstPart,secondPart;
    bool kaprekar;

    do{
        kaprekar = false;
        divider = 1;
        cin >> num;
        
        if(num != 0){
            numPow = (num * num);
            
            while(divider <= numPow * 10){
                firstPart = numPow / divider;
                secondPart = numPow % divider;
                divider *= 10;
                
                if(secondPart != 0){
                    if(firstPart + secondPart == num)
                        kaprekar = true;
                }
            }
            
            if(kaprekar)
                cout << "SI" << endl;
            else
                cout << "NO" << endl;
        }
    }while(num != 0);
}
