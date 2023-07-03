//6. Viê´t chuong tri`nh dê´m xem trong da~y a 1 , a 2 ,…, a n co´ bao nhiêu sô´ nguyên tô´
#include<stdio.h>
void Nhap(int a[],int n){
	for(int i=0;i<n;i++){
		printf("a[%d]= ",i);
		scanf("%d",&a[i]);
	}
}
void Xuat(int a[],int n){
	for(int i=0;i<n;i++){
		printf("\n a[%d]= %d\n",i,a[i]);		
	}
}
int SNT(int a){
	if(a<=1)
	return 0;
	else if(a<=3)
	return 1;
	else{
		for(int i=2;i<a;i++){
			if(a%i==0)
			return 0;
		}
		return 1;
	}
}
void DemSNT(int a[],int n){
	int dem=0;
    for(int i=1;i<=n;i++){
		if(SNT(a[i])==1)
			dem++;
		}
    printf("Tong cac so nguyen to la: %d", dem);	    
}
int main(){
	int a[100], n;
	printf("Nhap vao n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Xuat(a,n);
	DemSNT(a,n);
}
