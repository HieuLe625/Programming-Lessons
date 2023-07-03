#include<stdio.h>
int main(){
	int n, max1, max2;
	int a[100];
	printf("Nhap n: ");
	scanf("%d",&n);
	for(int i=0;i<n;i++){
		printf("Nhap a[%d]: ", i);
		scanf("%d",&a[i]);
	}
	for(int i=0;i<n;i++)
		printf("a[%d] = %d \n",i,a[i]);
	max1=a[0];
	max2=0;
	for(int i=1;i<n;i++){
		if(max1<a[i])
			max1 = a[i];
		}
	for(int i=0;i<n;i++){
		if(max1 == a[i]);   
        else if(max2 < a[i]){
            max2 = a[i];
	}
	}
	printf("Gia tri max1= %d\n",max1);
	printf("Gia tri max2= %d",max2);
}
			
