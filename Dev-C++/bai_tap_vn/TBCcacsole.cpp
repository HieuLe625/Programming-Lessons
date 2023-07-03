#include<stdio.h>
int main(){
	int a[100], n;
	float TBC;
	printf("Nhap vao gia tri n: ");
	scanf("%d",&n);
	for(int i=0;i<n;i++){
		printf("Nhap a[%d]:",i);
		scanf("%d",&a[i]);
	}
    for(int i=0;i<n;i++)
	printf("a[%d] = %d\n",i,a[i]);
	int S=0, dem=0; 
	for(int i=0;i<n;i++)
    if(a[i]%2==1){
	S= S + a[i];
	dem=dem+1;
}
	TBC=(float)S/n;
	printf("Tong cac so le la: %d\n",S);
	printf("TBC la: %.2f",TBC);
}

