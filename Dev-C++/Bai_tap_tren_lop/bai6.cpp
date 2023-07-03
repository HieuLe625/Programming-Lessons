//6. Viet chuong trình giai phuong trình bac 2 voi các he so nhap tu bàn phím (xét day du các
//truong hop, gom ca truong hop pt bac 2 tro thành pt bac nhat)
#include<stdio.h>
#include<math.h>
int main(){
	float a, b, c, delta, x, x1, x2;
	printf("Nhap vao a,b,c: ");
	scanf("%f%f%f", &a, &b, &c);
	if(a==0){
		if(b==0){
			if(c==0)
				printf("PTVSN");
			else
				printf("PTVN");
		}
		else{
			x=-c/b;
			printf("PT bac nhat co nghiem la: %.2f",x);	
		}
	}	
	else{
		delta=b*b-4*a*c;
		if(delta<0)
			printf("PTVN\n");
		else{
			if(delta>0){
				x1=(-b-sqrt(delta))/(2*a);
				x2=(-b+sqrt(delta))/(2*a);
				printf("Nghiem cua pt la: x1=%.2f, x2=%.2f",x1,x2);
			}
			else{
				x=-b/(2*a);
				printf("Nghiem kep la: x1=x2= %.2f",x);
			}
		}
	}
}
