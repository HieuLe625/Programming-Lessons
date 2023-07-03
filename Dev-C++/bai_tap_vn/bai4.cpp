//Cau 4.
#include <stdio.h>
#include <math.h>
int main(){
	int a,b,c,x,n;
	printf("Nhap so co 3 chu so: ");
	scanf("%d",&n);
	a = n/100;
	b = n%100/10;
	c = n%10;
	x = a + b + c;
	printf("Tong cua %d+%d+%d = %d",a,b,c,x);
}
