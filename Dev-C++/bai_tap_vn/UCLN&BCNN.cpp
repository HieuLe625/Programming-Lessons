#include<stdio.h>
int main(){
	int a, b, UCLN, BCNN;
	printf("nhap gia tri a: ");
	scanf("%d",&a);
	printf("nhap gia tri b: ");
	scanf("%d",&b);
	for (UCLN=a;UCLN>=1;UCLN--){
        if (a%UCLN==0 && b%UCLN==0){
            printf("UCLN(%d,%d)=%d\n",a,b,UCLN);
            break;
		}
	}
	for (BCNN=a;BCNN<=a*b;BCNN++){
        if (BCNN%a==0 && BCNN%b==0){
            printf("BCNN(%d,%d)=%d\n",a,b,BCNN);
            break;
        }
    }
}
