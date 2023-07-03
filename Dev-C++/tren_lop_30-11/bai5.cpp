//5. Viet chuong trình nhap mot mang mot chieu n so thuc. Ðem và thông báo ra màn hình trong
//mang có bao nhiêu phan tu duong.

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
		if(a[i]>0)
		dem++;
	}
	printf("So phan tu duong la: %d", dem);
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
