//11. Viet chuong tr�nh nhap v�o tu b�n ph�m so nguy�n duong n, t�nh v� in ra m�n h�nh giai thua cua n.
#include<stdio.h>
#include<conio.h>
int giaithua(int n){
	if(n==0 || n==1)
	return 1;
	else
	return n * giaithua(n-1);
}
int main(){
	int n;
	printf("Nhap n: ");
	scanf("%d", &n);
	printf("%d! = %1d", n, giaithua(n));
	getch();
}
