/*
6
4 4
XXXX
XXXX
XXXX
XXXX
3 3
XXX
XFX
XXX
3 3
XXX
FXX
XXX
4 3
XXXX
FXFX
XXXX
6 6
XXXXXX
XFXXFX
XXXXXX
XFXFXX
XXXXXX
XXXXXX
6 6
XXXXXX
XFXXFX
XXXXXX
XFFXXX
XXXXXX
XXXXXX
*/

//Victor Tebar
#include <iostream>

using namespace std;

int main(){
	int numTimes,width,height,countX,countY,figureCount;
	bool valid;
	char** yard;
	
	cin >> numTimes;
	for(int i=0;i<numTimes;i++){
		countX = countY = figureCount = 0;
		valid = true;
		cin >> width >> height;
		
		yard = new char*[width];
		
		for(int j=0; j < width; j++){
			yard[j] = new char[height];
		}

		for(int j=0;j < height; j++){
			for(int k=0; k < width; k++){
				cin >> yard[j][k];
			}
		}
		
		while(countY < height && valid){
			while(countX < width && valid){
				if((countX == 0 || countX == width - 1 || countY == 0 || countY == height - 1) && yard[countY][countX] == 'F'){
					valid = false;
				}
				else if(yard[countY][countX] == 'F' && (yard[countY][countX + 1] == 'F' 
				|| yard[countY][countX - 1] == 'F' || yard[countY + 1][countX] == 'F' 
				|| yard[countY - 1][countX] == 'F' || yard[countY + 1][countX + 1] == 'F'
				|| yard[countY + 1][countX - 1] == 'F' || yard[countY - 1][countX + 1] == 'F'
				|| yard[countY - 1][countX - 1] == 'F')){
					valid = false;
				}
				else if(yard[countY][countX] == 'F')
					figureCount++;
					
				countX++;
			}
			countX = 0;
			countY++;
		}
		
		if(figureCount != 0 && valid)
			cout << "VALIDA" << endl;
		else
			cout << "INVALIDA" << endl;
			
		for(int j=0; j < width;j ++)
			delete[] yard[j];
			
		delete[] yard;
	}
}
