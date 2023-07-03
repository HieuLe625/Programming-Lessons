// Tinh TBN 3 so thuc duong 
#include<stdio.h>
#include<conio.h>
#include<math.h>
int main(){
float a,b,c,TBN,d,e;
printf("Nhap vao cac so thuc duong a,b,c:\n");
scanf("%f%f%f",&a,&b,&c);
d=a*b*c;
e=1.0/3; //de may hieu e la so thuc
TBN= pow(d,e); // cac ham pow(x,y) hay sin(x) hay sqrt(x) thi x,y phai la bien
printf("Trung binh nhan 3 so vua nhap la:%f",TBN);
getch();
}
