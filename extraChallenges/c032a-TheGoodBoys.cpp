//Victor Tebar
#include <iostream>
#include <algorithm> 
#include <vector>
using namespace std;

struct kid{
	int goodness;
	int weight;
};

bool Compare(const kid &kid1,const kid &kid2){
	return ((kid1.goodness > kid2.goodness) ||(kid1.goodness == kid2.goodness && kid1.weight < kid2.weight));
}

int main(){
	int numTimes;
	int totalKids,goodness,weight;
	vector<kid> allKids;
	do{
		cin >> totalKids;
		if(totalKids != 0){
			for(int i=0;i<totalKids;i++){
				kid newKid;
				cin >> goodness;
				cin >> weight;
				newKid.goodness = goodness;
				newKid.weight = weight;
				allKids.push_back(newKid);
			}
			
			sort(allKids.begin(),allKids.begin() + allKids.size(),Compare);
			
			for(int i=0; i < totalKids;i++){
				cout << allKids[i].goodness << " " << allKids[i].weight << endl;
			}
			cout << endl;
			allKids.clear();
		}
		
	}while(totalKids != 0);
}
