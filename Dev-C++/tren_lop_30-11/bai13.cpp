//13. Viet chuong tr�nh nhap v�o tu b�n ph�m mot d�y so nguy�n gom n phan tu. T�nh trung b�nh
//cong c�c phan tu chan cua d�y.

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
// TBC cac so chan
void TBC(int a[], int n){
	int S=0;
	int dem=0;
	float TBC;
	for(int i=0;i<n;i++){
		if(a[i]%2==0)
		S=S+a[i];
		dem++;
		TBC=(float) S/dem;
	}
	printf("TBC cac so chan la: %.2f", TBC);
}

int main(){
	int a[100], n;
	printf("Nhap gia tri n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Xuat(a,n);
	TBC(a,n);
}
