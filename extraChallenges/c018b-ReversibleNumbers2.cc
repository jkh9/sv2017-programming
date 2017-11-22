// Challenge 18: Reversible numbers
// Victor Tebar

#include <iostream>
#include <cstdlib>
#include <cstring>

using namespace std;

int main()
{
    short numDigits,reverseDigits;
    size_t num,auxNum;
    size_t sum;
    string reversedNum;
    bool reversible;
    do
    {
        numDigits = reverseDigits = 0;
        reversedNum = "";
        reversible = true;
        cin >> num;
        auxNum = num;
        
        if(num != 0){
            while(auxNum > 0){
                reversedNum += (auxNum%10 + '0');
                auxNum /= 10;
                numDigits++;
            }
            
            auxNum = strtoull(reversedNum.c_str(),NULL,10);
            sum = num + auxNum;
            
            //Calculates the number of digits of the reversed number
            while(auxNum > 0)
            {
                auxNum /= 10;
                reverseDigits++;
            }
            
            if(numDigits != reverseDigits)
                reversible = false;
            
            while(sum > 0 && reversible)
            {
                if((sum%10)%2 == 0)
                    reversible = false;
                sum /= 10;
            }
            
            if(reversible)
                cout << "SI" << endl;
            else
                cout << "NO" << endl;
        }
    }
    while(num != 0);
}
    
