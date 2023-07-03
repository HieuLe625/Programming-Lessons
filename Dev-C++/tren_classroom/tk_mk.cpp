#include<stdio.h>
#include<conio.h>
#include<string.h>
int main(){
	int pass;
	char user[10];
	do{
		fflush(stdin);
		printf("User: ");
		scanf("%s",&user);
		printf("Passwork: ");
		scanf("%d",&pass);
	}while(strcmp(user,"admin")!=0 || pass!=123456);
	printf("Nhap thanh cong");
}
