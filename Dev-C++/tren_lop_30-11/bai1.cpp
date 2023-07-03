//1. Viêt chuong trinh nhâp va`o 1 day sô´ tu` a1, a2, …, an. In day sô´ vua nhâp ra man hinh theo
// nguyên tac 1 dong gôm 10 phân tu, dong cuôi co thê? co´ it hon 10 phân tu.
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
