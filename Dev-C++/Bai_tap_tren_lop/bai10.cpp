//S =2 + 4 + 6 + … + 2*n.
#include<stdio.h>
int main(){
	int n, S;
	printf("Nhap so nguyen n: ");
	scanf("%d",&n);
	S=0;
	for(int i=1;i<=n;i++){
		S=S+(2*i);
	}
	printf("S = %d",S);
}
