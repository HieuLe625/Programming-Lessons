//S =1^3 + 2^3 + 3^3 + … + n^3.
#include<stdio.h>
#include<math.h>
int main(){
	int n, S;
	printf("Nhap so nguyen n: ");
	scanf("%d",&n);
	S=0;
	for(int i=1;i<=n;i++){
		S=S+(pow(i,3));
	}
	printf("S = %d",S);
}
