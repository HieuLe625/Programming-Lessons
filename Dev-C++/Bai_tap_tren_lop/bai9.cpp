//S =1 + 3 + 5 + … + (2*n + 1).
#include<stdio.h>
#include<math.h>
int main(){
	int n, S;
	printf("Nhap so nguyen n: ");
	scanf("%d",&n);
	S=0;
	for(int i=0;i<=n;i++){
		S=S+(2*i+1);
	}
	printf("S = %d",S);
}
