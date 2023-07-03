#include<stdio.h>
 int main(){
    int a1, b1, c1, a2, b2, c2;
    int D, Dx, Dy, x, y;
    printf("Nhap a1 & a2: ");
    scanf("%d%d", &a1, &a2);
    printf("Nhap b1 & b2: ");
    scanf("%d%d", &b1, &b2);
    printf("Nhap c1 & c2: ");
    scanf("%d%d", &c1, &c2);
    D = a1 * b2 - a2 * b1;
    Dx = c1 * b2 - c2 * b1;
    Dy = a1 * c2 - a2 * c1;
    if (D == 0){
        if (Dx + Dy == 0)
            printf("He phuong trinh co vo so nghiem");
        else
            printf("He phuong trinh vo nghiem");
    }
    else {
        x = Dx / D;
        y = Dy / D;
        printf("He phuong trinh co nghiem (x, y) = (%d, %d)", x, y);
    }
}
