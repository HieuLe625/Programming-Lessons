#include<stdio.h>
void Nhap(float a[],int n){
	for(int i=0;i<n;i++){
		printf("a[%d]= ",i);
		scanf("%f",&a[i]);
	}
}
void Xuat(float a[],int n){
	for(int i=0;i<n;i++){
		printf("\n a[%d]= %.2f\n",i,a[i]);		
	}
}
void Dem(float a[], int n){
	int dem=0;
	for(int i=0;i<n;i++){
		if(a[i]<0)
		dem++;
	}
	printf("So phan tu am la: %d", dem);
}

int main(){
	int n;
	float a[100];
	printf("Nhap vao n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Xuat(a,n);
	Dem(a,n);
	
}
