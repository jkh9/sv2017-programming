/*
Chess boards
(drawing a 8x8 chess board. Each tile must have a certain size and char)

Entrada de ejemplo
2 #
0

Salida de ejemplo
|----------------|
|  ##  ##  ##  ##|
|  ##  ##  ##  ##|
|##  ##  ##  ##  |
|##  ##  ##  ##  |
|  ##  ##  ##  ##|
|  ##  ##  ##  ##|
|##  ##  ##  ##  |
|##  ##  ##  ##  |
|  ##  ##  ##  ##|
|  ##  ##  ##  ##|
|##  ##  ##  ##  |
|##  ##  ##  ##  |
|  ##  ##  ##  ##|
|  ##  ##  ##  ##|
|##  ##  ##  ##  |
|##  ##  ##  ##  |
|----------------|
*/

//Victor Tebar
#include <iostream>
#include <cstring>

using namespace std;

int main(){
    int size;
    char symbol;
    string frameStr,whiteStr,blackStr;

    do{
        frameStr = "";
        whiteStr = "";
        blackStr = "";
        
        cin >> size;
        
        if(size != 0){
            cin >> symbol;
            
            frameStr.assign(size * 8,'-');
            frameStr.insert(0,"|");
            frameStr += '|';
            
            for(int i=0; i < 8;i++){
                for(int j=0; j < size; j++){
                    if(i%2 == 0){
                        whiteStr += " ";
                        blackStr += symbol;
                    }
                    else{
                        whiteStr += symbol;
                        blackStr += " ";
                    }
                }
            }
            
            whiteStr.insert(0,"|");
            whiteStr += '|';
            blackStr.insert(0,"|");
            blackStr += '|';
            
            cout << frameStr << endl;
            for(int i=0;i < 8;i++){
                for(int j=0;j<size;j++){
                    if(i%2 == 0)
                        cout << whiteStr << endl;
                    else
                        cout << blackStr << endl;
                }
            }
            cout << frameStr << endl;
        }
    }while(size != 0);
}
