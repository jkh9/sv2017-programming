// Challenge 007: Artropodos (Acepta 293)
// Querubin Santana

#include <iostream>

using namespace std;

int main()
{
    int casos;
    int insectos, aracnidos, crustaceos, escolopendras;
    int numanillos;
    int totalpatas;
    
    cin >> casos;
    
    for( int i = 0; i < casos; i++)
    {
        cin >> insectos;
        cin >> aracnidos;
        cin >> crustaceos;
        cin >> escolopendras;
        cin >> numanillos;
        
        totalpatas = (insectos*6)+(aracnidos * 8)+(crustaceos * 10)+(escolopendras*numanillos*2);
        
        cout << totalpatas << endl;
    }
}
