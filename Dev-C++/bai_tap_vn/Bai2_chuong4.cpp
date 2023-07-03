#include<stdio.h>
#include<conio.h>
#include<string.h>
#include<math.h>
struct Doibong{
	char TenDoi[30];
	int Soluong;
	float Diem;
};
void Nhap(struct Doibong a[],int &n){
	for(int i=0;i<n;i++){
	   printf("Nhap ten: ");
	   fflush(stdin);
	   gets(a[i].TenDoi);
	   printf("Nhap so luong cau thu: ");
	   scanf("%d", &a[i].Soluong);
	   printf("Nhap diem: ");
	   scanf("%f", &a[i].Diem);
    }
}
void Xuat(struct Doibong a[],int n){
	for(int i=0;i<n;i++){
	printf("........\n");
	printf("\tTen: %s\n", a[i].TenDoi);
	printf("\tSo luong cau thu: %d \n", a[i].Soluong);
	printf("\tDiem: %.2f\n",a[i].Diem);
    }
}
int Sapxep(struct Doibong a[],int n)
{
	for(int i=0;i<n-1;i++)
	{
		for(int j=i+1;j<n;j++)
		{
		    if(strcmp(a[i].TenDoi, a[j].TenDoi)==1){
			Doibong k=a[i];
            a[i]=a[j];
            a[j]=k;
		    }
		}
	} 
}
int DiemMax(struct Doibong a[], int n){
	int max1, max2, max3;
	max1=0;
	max2=0;
	max3=0;
	for(int i=1;i<n;i++){
		if(max1 < a[i].Diem)
		   max1 = a[i].Diem;
		   else if (max1 == a[i].Diem){
		   max2 < a[i].Diem;
		   max2 = a[i].Diem;
	       }
		   else if (max1 == a[i].Diem && max2 == a[i].Diem){
		   max3 < a[i].Diem;
		   max3 = a[i].Diem;
		   }
	}
}

int main(){
	Doibong a[100];
	int n;
	printf("Nhap so luong doi bong: ");
	scanf("%d", &n);
	Nhap(a,n);
	DiemMax(a,n);
	Sapxep(a,n);
	Xuat(a,n);
	
	getch();
	
}
