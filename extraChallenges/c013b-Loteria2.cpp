// Reto 13: Lotería
// Victor Tebar

#include <iostream>

using namespace std;

int main(){
    int numTimes,numsLottery,num,count;
    cin >> numTimes;
    
    for(int i=0;i<numTimes;i++){
        count = 0;
        cin >> numsLottery;
        for(int j=0;j<numsLottery;j++){
            cin >> num;
            if(num%2 == 0)
                count++;    
        }
        cout << count << endl;
    }
}
