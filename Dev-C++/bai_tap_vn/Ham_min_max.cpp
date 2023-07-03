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
//Ham max
void max(int a[], int n){
	int max=a[0];
	for(int i=0;i<n;i++){
		if(a[i]>max)
		 max = a[i]; 
	}
	printf("So lon nhat la: %d\n", max);
}
//Ham min
void min(int a[], int n){
	int min=a[0];
	for(int i=0;i<n;i++){
		if(a[i]<min)
		 min = a[i]; 
	}
	printf("So nho nhat la: %d", min);
}
int main(){
	int a[100], n;
	printf("Nhap gia tri n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Xuat(a,n);
	max(a,n);
	min(a,n);
}

