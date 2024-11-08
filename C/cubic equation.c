#include<stdio.h>
#include<math.h>

int main() {
    float a, b, c, d;
    printf("Enter coefficient a: ");
    scanf("%f", &a);
    printf("Enter coefficient b: ");
    scanf("%f", &b);
    printf("Enter coefficient c: ");
    scanf("%f", &c);

    if (a == 0) {
        if (b == 0) {
            if (c == 0) {
                printf("The equation has infinitely many solutions");
            } else {
                printf("The equation has no solution");
            }
        } else {
            printf("The equation has a unique solution: %f", -c / b);
        }
    } else {
        d = b * b - 4 * a * c;
        if (d < 0) {
            printf("The equation has no real solution");
        } else if (d == 0) {
            printf("The equation has a double solution: %f", -b / (2 * a));
        } else {
            float x1 = (-b + sqrt(d)) / (2 * a);
            float x2 = (-b - sqrt(d)) / (2 * a);
            printf("The equation has two distinct solutions: %f, %f", x1, x2);
        }
    }

    return 0;
}
