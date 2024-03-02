#include <stdio.h>
#include<math.h>
int main() {
    int a, b;
    printf("Nhap so thu nhat: ");
    scanf("%d", &a);
    printf("Nhap so thu hai: ");
    scanf("%d", &b);
    int sum = a + b;
    int difference = a - b;
    printf("Tong hai so la: %d\n", sum);
    printf("Hieu hai so la: %d\n", difference);
    return 0;
}
