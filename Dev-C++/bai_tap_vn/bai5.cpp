//Cau 5
#include<stdio.h>
#include<conio.h>
int main(){
	int dd, mm, yyyy;
	printf("Nhap ngay: ");
	scanf("%d",&dd);
	printf("Nhap thang: ");
	scanf("%d",&mm);
	printf("Nhap nam: ");
	scanf("%d",&yyyy);
    if (dd>31 || dd<=0 || mm>12 || mm<=0 || yyyy<0)
	printf("Ngay nhap khong hop le!");
    else
	printf("Ngay thang nam la: %d/%d/%d",dd,mm,yyyy);
}
