#include<stdio.h>
int UCLN(int a, int b){
	while(a!=b){
		if(a>b)
			a=a-b;
		else
			b=b-a;
	}
	return a;
}

int BCNN(int a, int b){
	int bcnn = (a*b)/UCLN(a,b);
	return bcnn;
}
int main(){
	int a,b;
	printf("Nhap a, b: ");
	scanf("%d%d", &a, &b);
	printf("UCLN cua a, b la: %d \n", UCLN(a,b));
	printf("BCNN cua a, b la: %d \n", BCNN(a,b));
}
