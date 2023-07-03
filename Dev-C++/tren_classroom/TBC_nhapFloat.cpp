#include<stdio.h>
int main(){
	int n;
	float TBC,a[100],S;
	printf("Nhap vao gia tri n: ");
	scanf("%d",&n);
	for(int i=0;i<n;i++){
		printf("Nhap a[%d]:",i);
		scanf("%f",&a[i]);
	}
    for(int i=0;i<n;i++)
	   printf("a[%d] = %.2f\n",i,a[i]);
	int dem=0;
	 
	for(int i=0;i<n;i++)
       S= S + a[i];
	   dem=dem+1;
       TBC=(float)S/n;
       printf("Tong cua day la: %.2f\n", S);
	   printf("TBC la: %.2f",TBC);
}
