#include<stdio.h>
int main(){
	float a, b, cv, s;
	printf("Nhap vao a,b: ");
	scanf("%f%f", &a, &b);
	if(a<0 || b<0)
	   printf("Khong tinh duoc");
	else{
	   cv=(a+b)*2;
	   s=a*b;
	   printf("Chu vi la: %.2f\n", cv);
	   printf("Dien tich la: %.2f", s);
	}
}
