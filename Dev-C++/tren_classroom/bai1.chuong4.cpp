#include<stdio.h>
#include<string.h>
struct SinhVien{
	char HoTen[30];
	char Phai[10];
	float DiemTB;
};
void Nhap(struct SinhVien &a){ 
	fflush(stdin);
	printf("Nhap ho ten: ");
	gets(a.HoTen);
	fflush(stdin);
	printf("Nhap phai: ");
	gets(a.Phai);
	printf("Nhap diem TB: ");
	scanf("%f", &a.DiemTB);
}
void NhapDanhSach(struct SinhVien sv[], int n){
	for(int i=0;i<n;i++){
		printf("Nhap sv thu %d: \n",i);
		Nhap(sv[i]);
	}
}
void Xuat(struct SinhVien sv){
	printf("\tHo ten: %s\n", sv.HoTen);
	printf("\tPhai: %s\n",sv.Phai);
	printf("\tDiem TB: %.1f\n",sv.DiemTB);
}
void XuatDanhSach(struct SinhVien sv[], int n){
	for(int i=0;i<n;i++){
		printf("Thong tin sv thu %d\n", i);
		Xuat(sv[i]);
	}
}
void SapXepDanhSach(struct SinhVien sv[], int n){
	for(int i=0;i<n-1;i++){
		for(int j=i+1;j<n;j++){
			if(strcmp(sv[i].HoTen,sv[j].HoTen)==1){
				struct SinhVien t=sv[i];
				sv[i]=sv[j];
				sv[j]=t;
			}
		}
	}
	printf("Danh sach sv sap xep tang dan theo ho ten:\n");
	XuatDanhSach(sv,n);
}
int main(){
	struct SinhVien sv[100];
	int n;
	printf("Nhap so sinh vien: ");
	scanf("%d", &n);
	NhapDanhSach(sv,n);
	printf("****Danh sach SV da nhap vao******\n");
	XuatDanhSach(sv,n);
	SapXepDanhSach(sv,n);
}
