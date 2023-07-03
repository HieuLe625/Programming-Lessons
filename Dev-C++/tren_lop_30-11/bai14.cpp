//14. Viet chuong tr�nh nhap v�o tu b�n ph�m mot d�y so nguy�n gom n phan tu. T�nh trung b�nh
//nh�n c�c phan tu chan cua d�y.

#include<stdio.h>
#include<math.h>
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
// TBN cac so chan
void TBN(int a[], int n){
	int S=0;
	int dem=0;
	float TBN, t;
	for(int i=0;i<n;i++){
		if(a[i]%2==0)
		S=S*a[i];
		dem++;
		i++;
		t=float (1/dem);
		TBN=float (pow(S,t));
	}
	printf("TBN cac so chan la: %.2f", TBN);
}

int main(){
	int a[100], n;
	printf("Nhap gia tri n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Xuat(a,n);
	TBN(a,n);
}
