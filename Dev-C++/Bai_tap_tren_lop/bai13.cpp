//S=1*2*3 + 2*3*4 + ...+ n*(n+1)*(n+2).
#include<stdio.h>
#include<math.h>
int main(){
	int n, S;
	printf("Nhap so nguyen n: ");
	scanf("%d",&n);
	S=0;
	for(int i=1;i<=n;i++){
		S=S+(i*(i+1)*(i+2));
	}
	printf("S = %d",S);
}
