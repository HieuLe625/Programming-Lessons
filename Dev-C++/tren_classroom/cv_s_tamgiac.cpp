#include<stdio.h>
#include<math.h>
int main(){
	float a, b, c, cv, p, s;
	printf("Nhap vao a: ");
	scanf("%f", &a);
	printf("Nhap vao b: ");
	scanf("%f", &b);
	printf("Nhap vao c: ");
	scanf("%f", &c);
	if(a>0 && b>0 && c>0 && a+b>c && a+c>b && b+c>a){
		cv=a+b+c;
		p=cv/2;
		s=sqrt(p*(p-a)*(p-b)*(p-c));
		printf("Chu vi la: %.2f\n", cv);
		printf("Dien tich la: %.2f", s);
	}
	else 
	   printf("Khong tao thanh tam giac");
}
