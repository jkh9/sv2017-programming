// Querubin Santana

#include <iostream>
#include <stdlib.h>

using namespace std;

struct crio
{
	int conducta;
	int pesoregalos;
};

void quicksort(crio arraycrios[], int start, int end)
{
	crio pivot;
	int left, right;
	
	if(start < end)
	{
		pivot = arraycrios[(start+end)/2];
		left=start;
		right=end;
		do
		{
			while((arraycrios[left].conducta>pivot.conducta || arraycrios[left].conducta == pivot.conducta && arraycrios[left].pesoregalos<pivot.pesoregalos)&&left<=end)
			{
				left++;
			}
			while((arraycrios[right].conducta<pivot.conducta || arraycrios[right].conducta == pivot.conducta && arraycrios[right].pesoregalos>pivot.pesoregalos)&&right>=start)
			{
				right--;
			}
			
			if(left <= right)
			{
				crio aux = arraycrios[left];
				arraycrios[left] = arraycrios[right];
				arraycrios[right]=aux;
				left++;
				right--;
			}
			
		}while(left<=right);
		
		if(start<right)
		{
			quicksort(arraycrios,start,right);
		}
		
		if(left<end)
		{
			quicksort(arraycrios,left,end);
		}
	}
	
}




int main()
{	
	int numcrios;
	do
	{
		cin >> numcrios;
		
		if(numcrios!=0)
		{
		
			crio arraycrios[numcrios];
			
			for(int i = 0 ; i < numcrios; i++)
			{
				cin >> arraycrios[i].conducta;
				cin >> arraycrios[i].pesoregalos;
			}
			
			quicksort(arraycrios,0,numcrios-1);
			
			for(int i = 0 ; i < numcrios; i++)
			{
				cout << arraycrios[i].conducta << " ";
				cout << arraycrios[i].pesoregalos << endl;
			}
			cout << endl;
			
		}
	
	}while(numcrios != 0);
}
