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

//Victor Tebar
#include <iostream>

using namespace std;

int main(){
    unsigned long long first,multiplier,boxes,total;

    do{
        total = 0;
        cin >> first >> multiplier >> boxes;
        
        if(first != 0 && multiplier != 0 && boxes != 0)  // Note: this condition should not be here
        {
            total += first;
            
            for(unsigned long long i=0;i < boxes - 1;i++){
                total += (first * multiplier);
                first *= multiplier;
            }
            
            cout << total << endl;
        }
        
    }while(first != 0 || multiplier != 0 || boxes != 0); // Note: the exit condition was wrong
}
