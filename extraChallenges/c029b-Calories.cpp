#include <iostream>

using namespace std;

int main()
{
	int quemadas, comilonas, calorias, total, entrenamientos;
	
	do
	{
	cin >> quemadas;
	
	if(quemadas != 0)
	{
		total = 0;
		cin >> comilonas;
		
		for ( int i = 0; i < comilonas; i++)
		{
			cin >> calorias;
			total += calorias;
		}
		
		entrenamientos = total / quemadas;
		
		if(total % quemadas == 0)
			cout <<entrenamientos<< endl;
		else
			cout << entrenamientos + 1 << endl;
	}
	}while (quemadas != 0);
}
