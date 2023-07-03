//ax+b=0
#include<stdio.h>
void PTBN(float a, float b){
	float x;
	if(a==0){
		if(b==0)
			printf("PT vo so nghiem");
		else
			printf("PT vo nghiem");
	}
	else{
		x=-b/a;
		printf("Nghiem la: %.2f", x);
	}
}
int main(){
	int a=0,b=0, x=0, y=10;
	PTBN(a,b);
	printf("\n");
	PTBN(x+1,y);
	PTBN(1,3);
	PTBN(0,0);
}
