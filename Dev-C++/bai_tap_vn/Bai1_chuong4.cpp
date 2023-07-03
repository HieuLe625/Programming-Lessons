#include<stdio.h>
#include<conio.h>
#include<string.h>
struct SinhVien{
	char Ten[30];
	char Phai[30];
	float DiemTB;
};
void Nhap(struct SinhVien a[],int &n){
	for(int i=0;i<n;i++){
	   printf("Nhap ten: ");
	   fflush(stdin);
	   gets(a[i].Ten);
	   printf("Nhap tuoi: ");
	   fflush(stdin);
	   gets(a[i].Phai);
	   printf("Nhap diemTB: ");
	   scanf("%f", &a[i].DiemTB);
    }
}
void Xuat(struct SinhVien a[],int n){
	for(int i=0;i<n;i++){
	printf("........\n");
	printf("\tTen: %s\n", a[i].Ten);
	printf("\tPhai: %s \n", a[i].Phai);
	printf("\tDiem: %.2f\n",a[i].DiemTB);
    }
}
int Sapxep(SinhVien a[],int n)
{
	for(int i=0;i<n-1;i++)
	{
		for(int j=i+1;j<n;j++)
		{
		    if(strcmp(a[i].Ten, a[j].Ten)==1){
			SinhVien k=a[i];
            a[i]=a[j];
            a[j]=k;
		    }
		}
	} 
}
int main(){
	SinhVien a[100];
	int n;
	printf("Nhap so luong SV: ");
	scanf("%d", &n);
	Nhap(a,n);
	Sapxep(a,n);
	Xuat(a,n);
	
	getch();
	
}
