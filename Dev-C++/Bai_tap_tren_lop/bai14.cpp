//S= (1/2.3) + (1/3.4) + .... + (1/n.(n+1)). 
#include<stdio.h>
int main(){
	int n, x, y; 
	float S;
	printf("Nhap so nguyen n: ");
	scanf("%d",&n);
	S=0;
	for(int i=2;i<=n;i++){
		//x=i*(i+1);
		//y=1/x;
		S = S + float(1/(i*(i+1)));
	}
	printf("S = %f",S);
}
// bai nay` em ko ra duoc a.
// em nghi~ no' sai o cho 1/
