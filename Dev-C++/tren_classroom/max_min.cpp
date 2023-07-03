#include<stdio.h>
int main(){
	int n;
	float a[100];
	printf("Nhap n: ");
	scanf("%d",&n);
	for(int i=0;i<n;i++){
		printf("Nhap a[%d]: ", i);
		scanf("%f",&a[i]);
	}
	for(int i=0;i<n;i++)
		printf("a[%d] = %.1f \n",i,a[i]);
	//tim so lon nhat
	float  max=a[0];
	for(int i=1;i<n;i++){
		if(a[i]>max)
			max=a[i];
	}
	printf("So lon nhat la: %.1f\n", max);
	//tim so be nhat
	float min=a[0];
	for(int i=1;i<n;i++){
		if( a[i]<min)
			min=a[i];
	}
	printf("So be nhat la: %.1f", min);
}
