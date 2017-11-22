// Challenge 17, hyperpar number
// Victor Tebar

#include <iostream>

using namespace std;

int main()
{
    long long num;
    bool hyperpar;
    do{
        hyperpar = true;
        cin >> num;
        if(num >= 0)
        {
            while(num!= 0)
            {
                if(num%2 != 0)
                    hyperpar = false;
                num /= 10;
            }
            if(hyperpar)
                cout << "SI" << endl;
            else
                cout << "NO" << endl;
        }
    }
    while(num >= 0);
}
