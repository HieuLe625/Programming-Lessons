//Cau 3.
#include<stdio.h>
int main(){
	int n, a, b, c, d;
	printf("Nhap vao so co 4 chu so : ");
	scanf("%d", &n);
		a = n/1000;
    	b = n%1000/100;
    	c = n%100/10;
    	d = n%10;
	printf("Nguoc lai cua day so la: %d%d%d%d\n", d, c, b, a);
}
