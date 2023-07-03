#include<stdio.h>
//Ham nhap
void Nhap(int a[], int n){
	for(int i=0;i<n;i++){
		printf("Nhap a[%d] = ", i);
		scanf("%d", &a[i]);
	}
}
//Ham xuat
void Xuat(int a[], int n){
	for(int i=0;i<n;i++)
		printf("a[%d] = %d \n", i, a[i]);
}
//Ham Tong
void Tong(int a[], int n){
	int S=0;
	for(int i=0;i<n;i++){
		S=S+a[i];
	}
    printf("Tong day so la: %d", S);
}
int main(){
	int a[100], n;
	printf("Nhap gia tri n: ");
	scanf("%d",&n);
	Nhap(a,n);
	Xuat(a,n);
	Tong(a,n);
}

