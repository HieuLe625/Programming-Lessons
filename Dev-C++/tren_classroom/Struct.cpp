#include<stdio.h>
struct SinhVien{
	char Ten[30];
	int Tuoi;
	float Diem;
};
void Nhap(struct SinhVien &a){
	printf("Nhap ten: ");
	fflush(stdin);
	gets(a.Ten);
	printf("Nhap tuoi: ");
	scanf("%d",&a.Tuoi);
	printf("Nhap diem: ");
	scanf("%f", &a.Diem);
}
void Xuat(struct SinhVien a){
	printf("\tTen: %s\n", a.Ten);
	printf("\tTuoi: %d \n", a.Tuoi);
	printf("\tDiem: %.2f",a.Diem);
}
int main(){
	SinhVien sv1, sv2;
	printf("Nhap thong tin sv1: \n");
	Nhap(sv1);
	printf("Thong tin sv1: \n");
	Xuat(sv1);
	sv2=sv1;
	printf("\nThong tin sv2: \n");
	Xuat(sv2);
	
}
