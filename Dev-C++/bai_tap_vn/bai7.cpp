//Cau 7.
#include<stdio.h>
#include "conio.h"
int main(){
	int n, a, b, c;
	printf("Nhap so giay: ");
	scanf("%d",&n);
	a = n/3600;
	b = (n%3600)/60;
	c = (n%3600)%60;
	printf("%d giay doi thanh gio : phut : giay la: %d:%d:%d",n,a,b,c);
}
