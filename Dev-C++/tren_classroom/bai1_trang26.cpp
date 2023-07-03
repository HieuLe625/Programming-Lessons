#include<stdio.h>
#include<math.h>
int main(){
	int n;
	float S,x;
	printf("Nhap n: ");
	scanf("%d",&n);
	printf("Nhap x: ");
	scanf("%f", &x);
	S=0;
	for(int i=0;i<=n;i++){
		S=S+((1+pow(x,i))/(i+1));
	}
	printf("S = %.2f",S);
}
