#include<stdio.h>
#include<conio.h>
const luongcb=730000;
float luong, bacluong;
char hoten[40]
void main(){
	printf("Nhap ho ten:");
	gets(hoten);
	scanf("%s", &hoten);
	fflush(stdin);
	printf("Nhap bacluong:");
	scanf("%f", &bacluong);
	luong = luongcb*bacluong;
	printf("nhan vien %s linh %.2f (d/thang)",hoten,luong);
	getch();
}
