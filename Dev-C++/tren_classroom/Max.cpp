#include<stdio.h>
int main(){
	int n, max;
	int a[100];
	printf("Nhap n: ");
	scanf("%d",&n);
	for(int i=0;i<n;i++){
		printf("Nhap a[%d]: ", i);
		scanf("%d",&a[i]);
	}
	for(int i=0;i<n;i++)
		printf("a[%d] = %d \n",i,a[i]);
	max=a[0];
	for(int i=1;i<n;i++){
		if(a[i]>max)
			max=a[i];
		}
		printf("So lon nhat la: %d\n", max);
	}
