//ax^2 + bx + c =0
#include<stdio.h>
#include<math.h>
void PTBH (float a ,float b , float c){
  float x , delta,x1,x2;
  if(a==0){
	if(b==0){
		if(c==0)
			printf("PTVSN");
		else
			printf("PTVN");
	}
    else{
		x = -b/a;
		printf("nghiem cua pt x = %f",x);	
    }
 }
  else{
	delta = b*b - 4*a*c;
	if(delta < 0)
		printf("PTVN");
	else if( delta > 0){
			x1 = ( -b -sqrt(delta)) / (2*a);
			x2 =(-b + sqrt(delta)) / (2*a);
			printf("nghiem cua pt la x1=%f , x2 = %f",x1,x2);
		}
		else {
			x =x1=x2= -b / (2*a);
			printf("nghiem cua pt la x = %f",x);
		}
    }
}
int main (){
	float a , b , c;
	printf("nhap a,b,c:");
	scanf("%f%f%f",&a,&b,&c);
	PTBH(a,b,c);
}
