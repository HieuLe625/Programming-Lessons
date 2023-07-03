//2. Viet chuong trình nhap mot mang mot chieu n so nguyên. Sap xep mang theo thu tu tang dan.
//In ra màn hình mang truoc và sau khi sap xep.

#include<stdio.h>
void Nhap(int a[],int n){
	for(int i=0;i<n;i++){
		printf("a[%d]= ",i);
		scanf("%d",&a[i]);
	}
}
void Xuat(int a[],int n){
	for(int i=0;i<n;i++){
		printf("\n a[%d]= %d\n",i,a[i]);		
	}
}
int Sapxep(int a[], int n){
    int t;
	for(int i=0;i<n;i++){
		for(int j=i+1;j<n;j++){
			if(a[i]>a[j]){
				t=a[i];
				a[i]=a[j];
				a[j]=t;
			}
			
		}
	}
}

int main(){
	int a[100], n;
	printf("Nhap vao n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Sapxep(a,n);
	Xuat(a,n);
	
}
