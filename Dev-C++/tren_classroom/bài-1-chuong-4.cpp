#include<stdio.h>
#include<conio.h>
#include<string.h>
struct SinhVien
{
	char Hovaten[30],phai[10],Ngaysinh[10];

	
};

void nhap (SinhVien a[],int &n)
{
	
	for(int i=0;i<n;i++)
	{
		fflush(stdin);
		printf("\nNhap Ho Va Ten SV: ");
		gets(a[i].Hovaten);
		fflush(stdin);
		printf("\nNhap phai: ");
		gets(a[i].phai);
		fflush(stdin);
		printf("\nNhap ngay sinh: ");
		gets(a[i].Ngaysinh);
		
	}
}
int Sapxep(SinhVien a[],int n)
{
	for(int i=0;i<n-1;i++)
	{
		for(int j=i+1;j<n;j++)
		{
		   if(strcmp(a[i].Hovaten,a[j].Hovaten)==1)
		  {
			SinhVien k=a[i];
            a[i]=a[j];
            a[j]=k;
		  }
		}
	} 
}
void xuat(SinhVien a[],int n)
{
	for(int i=0;i<n;i++)
	{
		printf("\n...");
		printf("\nHo va ten: %s",a[i].Hovaten);
		printf("\nphai: %s",a[i].phai);
		printf("\nNgay sinh: %s",a[i].Ngaysinh);
		
	}
}
int main()
{
	int n;
	
	SinhVien a[100];
	printf("\nNhap so luong SV: ");
	scanf("%d",&n);
	nhap(a,n);
	Sapxep(a,n);
	xuat(a,n);

	
	getch();
}
