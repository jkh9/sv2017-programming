// Victor Tebar

/* Challenge 052: Next plate

Entrada de ejemplo
1234 BBB
9999 BBZ
9999 BBD
9999 ZZZ

Salida de ejemplo 
1235 BBB
0000 BCB
0000 BBF
*/

#include <iostream>
#include <string>
#include <cstdio>

using namespace std;

int main(){
    int num;
    string letters;
    string strNum;
    do{
        cin >> num >> letters;
        if(num != 9999 || letters != "ZZZ"){
            num++;
            if(num == 10000){
                num = 0;
                if(letters[2] == 'Z'){
                    letters[2] = 'B';
                    if(letters[1] == 'Z'){
                        if(letters[0] + 1 == 'E' || letters[0] + 1 == 'I' || letters[0] + 1 == 'O' || letters[0] + 1 == 'U')
                            letters[0] += 2;
                        else
                            letters[0]++;
                        letters[1] = 'B';
                    }
                    else{
                        if(letters[1] + 1 == 'E' || letters[1] + 1 == 'I' || letters[1] + 1 == 'O' || letters[1] + 1 == 'U')
                            letters[1] += 2;
                        else
                            letters[1]++;
                    }
                }   
                else{
                    if(letters[2] + 1 == 'E' || letters[2] + 1 == 'I' || letters[2] + 1 == 'O' || letters[2] + 1 == 'U')
                        letters[2] += 2;
                    else
                        letters[2]++;
                }
            }
            printf("%04d",num);
            cout << " " << letters << endl;
        }
    }while(num != 9999 || letters != "ZZZ");
}
