//1. Viet chuong tr�nh nhap v�o tu b�n ph�m do d�i hai canh cua h�nh chu nhat Kiem tra neu do
//d�i nhap v�o duong th� t�nh v� in ra m�n h�nh chu vi, dien t�ch cua h�nh chu nhat d�, nguoc
//lai, neu do d�i nhap v�o �m th� th�ng b�o kh�ng t�nh duoc.
#include<stdio.h>
int main(){
	float a, b, cv, s;
	printf("Nhap vao a,b: ");
	scanf("%f%f", &a, &b);
	if(a<0 || b<0)
	   printf("Khong tinh duoc");
	else{
	   cv=(a+b)*2;
	   s=a*b;
	   printf("Chu vi la: %.2f\n", cv);
	   printf("Dien tich la: %.2f", s);
	}
}
