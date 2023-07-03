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
float TBC(int a[], int n){
	int S=0;
	float tbc;
	for(int i=0;i<n;i++){
		S=S+a[i];
	}
	tbc=(float)S/n;
	return tbc;
}
int main(){
	int a[100], n;
	printf("Nhap so phan tu: ");
	scanf("%d", &n);
	Nhap(a,n);
	Xuat(a,n);
	printf("\nTBC cua day la: %.2f", TBC(a,n));
}
