#include<stdio.h>
#include<math.h>
int main(){
	int a, b, UCLN, BCNN, T;
	printf("Nhap gia tri a > 0 : ");
	scanf("%d", &a);
	printf("Nhap gia tri b > 0 : ");
	scanf("%d", &b);
	if( a>=0 && b>=0){
		if(a==0 && b==0)
	    printf("Khong ton tai UCLN, BCNN \n");
	    else if(a==0 || b==0){
		
	    if(a==0)
	    printf("khong co UCLN, BCNN = %d", b);
	    else
	    printf("khong co UCLN, BCNN = %d", a);
 	    }
    }
    else{
    	T= a*b;
	while(a!=b){
		if(a>b){
			a = a-b;
		}
	    else{
	    	b = b-a;
		}
	}
	printf("UCLN = %d\n",a);
	printf("BCNN = %d\n",T /a );
	}
}
	
	

