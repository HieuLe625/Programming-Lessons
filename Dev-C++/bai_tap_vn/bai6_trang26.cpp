#include<stdio.h>
#include<math.h>
   int main(){
   	int n;
   	float s,x;
   	printf("nhap gia tri n: ");
   	scanf("%d",&n);
   	printf("Nhap x: ");
   	scanf("%f", &x);
   	s=2013;
   	int i=1;
   	while(i<=n){
	   	s =s+((pow(x,i))/(i));
	   	i++;	
	}
	s=sqrt(s);
   	printf("tong day la: %.2f", s);
}
