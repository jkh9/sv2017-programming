//Victor Tebar
#include <iostream>
#include <vector>

using namespace std;

int main()
{
    long long number,numberAux;
    int result;
    vector <long long> allDigits;
    do
    {
        result = 0;
        cin >> number;
        numberAux = number;
        if(number >= 0)
        {
            while(numberAux > 0)
            {
                allDigits.push_back(numberAux%10);
                numberAux /= 10;
            }
            if(number == 0)
                allDigits.push_back(0);
            for(size_t i=allDigits.size();i>0;i--)
            {
                result += allDigits[i-1];
                cout << allDigits[i-1];
                if(i != 1)
                    cout << " + ";
                else
                    cout << " = ";
            }
            cout << result << endl;
            allDigits.clear();
        }
    }
    while(number >= 0);
}
    
