#include<stdio.h>

int main(){
    float radius, circumference, area;
    const float PI = 3.14;

    printf("Enter the radius: ");
    scanf("%f", &radius);

    circumference = 2 * PI * radius;
    area = radius * radius * PI;

    printf("Circumference: %f \n", circumference);
    printf("Area: %f", area);

    return 0;
}
