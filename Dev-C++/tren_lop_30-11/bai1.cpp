//1. Vi�t chuong trinh nh�p va`o 1 day s�� tu` a1, a2, �, an. In day s�� vua nh�p ra man hinh theo
// nguy�n tac 1 dong g�m 10 ph�n tu, dong cu�i co th�? co� it hon 10 ph�n tu.
#include<stdio.h>
void Nhap(int a[],int n){
	for(int i=0;i<n;i++){
		printf("a[%d]= ",i);
		scanf("%d",&a[i]);
	}
}
void Xuat(int a[],int n){
	for(int i=0;i<n;i++){
		printf("%d\t",a[i]);
		if((i+1)%10==0)
		printf("\n");
		
	}
}
int main(){
	int a[100], n=10;
	//printf("Nhap vao 10 phan tu:\n");
	printf("Nhap vao n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Xuat(a,n);
	
}
