//3. Viet chuong trình nhap vào tu bàn phím hai so nguyên duong a, b. Tìm uoc chung lon nhat
//và boi chung nho nhat cua hai so dó.
#include<stdio.h>
int main(){
	int a, b, T, UCLN, BCNN;
	printf("Nhap gia tri a,b: ");
	scanf("%d%d", &a, &b);
	T=a*b;
	while(a!=b){
		if(a>b)
		  a=a-b;
		else
		  b=b-a;
	}
	UCLN=a;
	printf("UCLN la: %d\n", UCLN);
	BCNN = (T)/UCLN;
	printf("BCNN la: %d", BCNN);
}
