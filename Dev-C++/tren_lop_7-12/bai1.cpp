#include<stdio.h>
void Nhap(int a[], int n){
	for(int i=0;i<n;i++){
		printf("Nhap a[%d]= ",i);
		scanf("%d", &a[i]);
	}
}

//Xuat mang, ma` moi dong` co' 10 phan tu 
void Xuat(int a[], int n){
	for(int i=0;i<n;i++){
		printf("%d \t", a[i]);
		if((i+1)%10==0)
		printf("\n");
	}
}

//Tim kiem 1 phan tu x cho truoc
void Timkiem(int a[], int n){
	int x;
	printf("\nNhap gia tri can tim: ");
	scanf("%d",&x);
	for(int i=0;i<n;i++){
		if(a[i]==x)
		break;
	}
	if(x==n)
	printf("Khong co x trong day");
	else
	printf("X co trong day so");
}

//kiem tra bao nhieu cap so = tong 2 so truoc
void Demcapso(int a[], int n){
	int dem=0;
	for(int i=0;i<n;i++){
		if(a[i+2] == a[i+1] + a[i])
		dem++;
	}
	printf("\nSo cap ma 2 so truoc = so sau la: %d",dem);
}

//kiem tra trong day so co bao nhieu cap ai + aj (i#j) la SNT
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
void SocaplaSNT(int a[], int n){
	int dem=0;
	for(int i=0;i<n-1;i++){
		for(int j=i+1;j<n;j++){
			if(SNT (a[i] + a[j])==1)
			dem++;
		}
	}
	printf("\nSo cap thoa man tong 2 so la SNT la: %d", dem);
}
int main(){
	int a[100], n;
	printf("Nhap vao n: ");
	scanf("%d", &n);
	Nhap(a,n);
	Xuat(a,n);
	Timkiem(a,n);
	Demcapso(a,n);
	SocaplaSNT(a,n);
}
