//Victor Tebar
// Ch.09 Claras y Oscuras (Acepta 413)

#include <iostream>

using namespace std;

int main(){
    int numTimes,width,height,white,black,even,odd;
    cin >> numTimes;
    for(int i=0;i<numTimes;i++){
        white = 0;
        black = 0;
        cin >> width >> height;
        
        if(width%2 == 0 && height%2 == 0){
            black = (width/2)*height;
            white = (width/2)*height;
        }
        else if(width%2 != 0 && height%2 != 0){
            black = ((width*height)-(width*height/2));
            white = black-1;
        }
        else{
            if(width%2 == 0){
                even = width;
                odd = height;
            }else{
                even = height;
                odd = width;
            }
            black = (even/2*odd);
            white = black;
        }
        cout << black << " " << white << endl;
    }
    return 0;
}
