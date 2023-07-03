//3. Viet chuong trình nhap mot mang mot chieu n so thuc. Sap xep mang theo thu tu giam dan.
//In ra màn hình mang truoc và sau khi sap xep.

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
int Sapxep(float a[], int n){
    int t;
	for(int i=0;i<n;i++){
		for(int j=i+1;j<n;j++){
			if(a[i]<a[j]){
				t=a[i];
				a[i]=a[j];
				a[j]=t;
			}
		}
	}
}

int main(){
	int n;
	float a[100];
	printf("Nhap vao n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Sapxep(a,n);
	Xuat(a,n);
	
}
