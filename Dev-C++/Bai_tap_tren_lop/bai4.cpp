//4. Viet chuong tr�nh nhap v�o so nguy�n a to b�n ph�m, kiem tra xem a c� phai l� so nguy�n to
//hay kh�ng.
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
