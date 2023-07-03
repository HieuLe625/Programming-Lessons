//7. Viet chuong trình nhap mot mang mot chieu n so thuc. Tìm và in ra màn hình giá tri lon nhat
//cua mang.
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

void max(int a[], int n){
	int max=a[0];
	for(int i=0;i<n;i++){
		if(a[i]>max)
		 max = a[i]; 
	}
	printf("So lon nhat la: %d\n", max);
}

int main(){
	int a[100], n;
	printf("Nhap gia tri n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Xuat(a,n);
	max(a,n);
}
