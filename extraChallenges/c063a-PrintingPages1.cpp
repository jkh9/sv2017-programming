/*
Imprimiendo páginas sueltas

Entrada de ejemplo

1 2 3 4 0
1 2 5 6 0
100 122 123 125 0
0

Salida de ejemplo

1-4
1-2,5-6
100,122-123,125

https://www.aceptaelreto.com/problem/statement.php?id=405
*/

// Víctor Tebar

#include <iostream>
#include <vector>

using namespace std;


int main(){
    vector<string> serie;
    int num;
    string strNum;
    
    do{
        int lastNumber = -1;
        cin >> num;
        if(num != 0){
            serie.push_back(to_string(num));
            lastNumber = num;
            int count = 0;
            while(num != 0){
                cin >> num;
                if(num == 0){
                    char buff3[30];
                    string strLast = to_string(lastNumber);
                    if(strLast != serie[count]){
                        serie.push_back("-");
                        serie.push_back(to_string(lastNumber));
                    }
                    count += 2;
                }
                else if(num != lastNumber + 1){
                    string strLast = to_string(lastNumber);
                    if(strLast != serie[count]){
                        serie.push_back("-");
                        serie.push_back(to_string(lastNumber));
                        count += 2;
                    }
                    serie.push_back(",");
                    serie.push_back(to_string(num));
                    count += 2;
                }
                lastNumber = num;
            }
            
            for(size_t i=0;i < serie.size();i++){
                cout << serie[i];
            }
            cout << endl;
            num = -1;
            serie.clear();
        }
    }while(num != 0);
}
