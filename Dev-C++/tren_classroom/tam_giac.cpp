#include<stdio.h>
#include<math.h>
int main(){
	float xA,yA,xB,yB,xC,yC, CV, DT, AB, BC, AC, p;
	printf("Nhap toa do diem A(xA,yA): ");
	scanf("%f%f", &xA,&yA);
	printf("Nhap toa do diem B(xB,yB): ");
	scanf("%f%f", &xB,&yB);
	printf("Nhap toa do diem C(xC,yC): ");
	scanf("%f%f", &xC,&yC);
	printf("Toa do cac diem da nhap vao la: \n");
	printf("A(%.2f, %.2f)  B(%.2f, %.2f)   C(%.2f, %.2f)\n",xA,yA,xB,yB,xC,yC);
	//tinh do dai cac doan thang AB, BC, AC
	AB=sqrt((xA-xB)*(xA-xB) + (yA-yB)*(yA-yB));
	BC=sqrt((xB-xC)*(xB-xC) + (yB-yC)*(yB-yC));
	AC=sqrt((xA-xC)*(xA-xC) + (yA-yC)*(yA-yC));
	
	if(AB>0 && BC>0 && AC>0 && (AB+BC>AC) && (BC+AC>AB) && (AC+AB>BC))
	{
		CV=AB+BC+AC;
		p=CV/2;
		DT=sqrt(p*(p-AB)*(p-BC)*(p-AC));
		printf("Do dai AB= %.2f\n", AB);
		printf("Do dai BC= %.2f\n", BC);
		printf("Do dai AC= %.2f\n", AC);
		printf("\nChu vi la: %.2f\n", CV); 
		printf("Dien tich la: %.2f", DT);
	}
	else
		printf("A,B,C khong tao thanh tam giac \n");

}
