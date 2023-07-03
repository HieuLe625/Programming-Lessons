#include<stdio.h>
int GTLN(int a, int b){
	if(a>b)
		return a;
	else
		return b;
}
int main(){
	int a=5, b=10;
	printf("GTLN la: %d", GTLN(a,b));
}

