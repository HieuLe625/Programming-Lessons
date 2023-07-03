#include <stdio.h>
#include <utility>
void NhapMaTran(int a[][100], int m, int n){
   for(int i = 0; i < m; i++)
      for(int j = 0; j < n; j++)
      {
         printf("A[%d][%d] = ", i, j);
         scanf("%d", &a[i][j]);
      }
}
 
void XuatMaTran(int a[][100], int m, int n){
   for(int i = 0; i < m; i++)
   {
      for(int j = 0; j < n; j++)
         printf("%d\t", a[i][j]);
      printf("\n");
   }
}

//Tim phan tu co gia tri lon nhat va nho nhat
void MinMax(int a[][100], int m, int n){
	int min, max;
    min = a[0][0];
    max = a[0][0];
    for (int i = 0; i < m; i++) 
	{
        for (int j = 0; j < n; ++j)
		{
            if (a[i][j] > max)
                max = a[i][j];
            if (a[i][j] < min)
                min = a[i][j];
        }  
    }
    printf("Phan tu lon nhat : %d\n", max);
    printf("Phan tu nho nhat : %d\n", min);
}
int main(){
    int a[100][100];
    int m,n;
    printf("nhap so hang n = "); 
	scanf("%d",&n);
    printf("nhap so cot m = "); 
	scanf("%d",&m);
    printf("nhap vao ma tran:\n");
    NhapMaTran(a, m, n);
    XuatMaTran(a, m, n);
    MinMax(a, m, n);
}
