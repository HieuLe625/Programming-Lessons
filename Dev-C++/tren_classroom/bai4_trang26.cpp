#include<stdio.h>
#include<math.h>
   int main(){
   	int n;
   	float s,x;
   	printf("nhap gia tri n: ");
   	scanf("%d",&n);
   	printf("Nhap x: ");
   	scanf("%f", &x);
   	s=x;
   	int i=1;
   	while(i<=n){
	   	s = x+sqrt(s);
	   	i++;	
	}
	s=sqrt(s);
   	printf("tong day la: %.2f", s);
   }
