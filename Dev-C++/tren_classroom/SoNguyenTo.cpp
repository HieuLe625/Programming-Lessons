#include<stdio.h>
int main(){
	int a;
	int dem=0;
	printf("Nhap vao a: ");
	scanf("%d", &a);
	for(int i=1;i<=a;i++){
		if(a%i==0)
			dem=dem+1;
	}
	if(dem==2)
		printf("a la so nguyen to.");
	else
		printf("a khong phai la so nguyen to.");	
}

