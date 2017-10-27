//Victor Tebar
//Postes para un cercado

#include <iostream>

using namespace std;

int main(){
    int width,height,widthPost,heightPost,minDistance,post;
    do{
        heightPost = 0;
        widthPost = 0;
        post = 0;
        cin >> width >> height >> minDistance;
        if(minDistance != 0 && width != 0 && height != 0){
            if(width/minDistance == 0 && height/minDistance == 0){
                post = 4;
            }
            else if(width/minDistance != 0 && height/minDistance != 0){
                post += 4;
                widthPost += (width/minDistance);
                if(width%minDistance == 0)
                    widthPost--;
                widthPost *= 2; 
                heightPost += (height/minDistance);
                if(height%minDistance == 0)
                    heightPost--;
                heightPost *= 2;
                post += (widthPost + heightPost);
            }
            else{
                post += 4;
                if(width/minDistance == 0){
                    heightPost += (height/minDistance);
                    if(height%minDistance == 0)
                        heightPost--;
                    heightPost *= 2;
                }
                else{
                    widthPost += (width/minDistance);
                    if(width%minDistance == 0)
                        widthPost--;
                    widthPost *= 2; 
                }
                
                post += (widthPost + heightPost);
            }
            cout << post << endl;
        }
    }while(minDistance != 0 && width != 0 && height != 0);
    
    return 0;
}
