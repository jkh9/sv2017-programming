// Reto 19. Palabras pentavocalicas
// Victor Tebar
#include <iostream>
#include <cstring>

using namespace std;

int main()
{
    int numTimes;
    int count;
    short a,e,i,o,u;
    string word;
    
    cin >> numTimes;
    cin.ignore();
    
    for(int time=0;time<numTimes;time++)
    {
        a = e = i = o = u = 0;
        count = 0;
        
        getline(cin,word);
        while(count < word.length()){
            switch(word[count]){
                case 'a': a++; break;
                case 'e': e++; break;
                case 'i': i++; break;
                case 'o': o++; break;
                case 'u': u++; break;
            }
            count++;
        }
        
        if(a >= 1 && e >= 1 && i >= 1 && o >= 1 && u >= 1)
            cout << "SI" << endl;
        else
            cout << "NO" << endl;
    }
}
    
