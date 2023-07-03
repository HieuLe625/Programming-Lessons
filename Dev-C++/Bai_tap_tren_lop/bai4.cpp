//4. Viet chuong trình nhap vào so nguyên a to bàn phím, kiem tra xem a có phai là so nguyên to
//hay không.
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
	   printf("a la so nguyen to");
	else
	   printf("a ko phai la so nguyen to");
}
