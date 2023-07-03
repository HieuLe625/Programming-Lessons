//10. Viet chuong tr�nh nhap mot mang mot chieu gom n so nguy�n duong. T�nh v� th�ng b�o ra
//m�n h�nh tong c�c phan tu c� gi� tri chan trong mang.

#include<stdio.h>
void Nhap(int a[], int n){
	for(int i=0;i<n;i++){
		printf("Nhap a[%d] = ", i);
		scanf("%d", &a[i]);
	}
}

void Xuat(int a[], int n){
	for(int i=0;i<n;i++)
		printf("a[%d] = %d \n", i, a[i]);
}
// Tong cac so chan
void Tong(int a[], int n){
	int S=0;
	for(int i=0;i<n;i++){
		if(a[i]%2==0)
		S=S+a[i];
	}
	printf("Tong so chan cua day la: %d", S);
}

int main(){
	int a[100], n;
	printf("Nhap gia tri n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Xuat(a,n);
	Tong(a,n);
}
