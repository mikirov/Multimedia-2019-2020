#include <iostream>

using namespace std;

void midpoint(int x1, int x2, int y1, int y2){
	int delta_x = x2 - x1;
	int delta_y = y2 - y1;

	float slope = (float)delta_y / (float)delta_x;

	int y = y1;
	for(int x = x1; x <= x2; x++){
		
		float current_y = (float)y1 + slope * (float)(x - x1);
	        //cout << "current_y: " << current_y << endl;	
		if(current_y > y + 1/2){
			y++;
			cout << "x:" << x << " y:" << y << endl;
		}
		else{
			cout << "x:" << x << " y:" << y << endl;
		}	
	}
}

int main(){

	int x1, x2, y1, y2;
	cin >> x1 >> y1 >> x2 >> y2;
	midpoint(x1, x2, y1, y2);
}
