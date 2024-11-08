#include<stdio.h>
#include<math.h>

int main() {
    printf("QUADRATIC EQUATION SOLVER\n");

    float a, b, c;
    float discriminant, x1, x2;

    printf("Enter coefficient a: ");
    scanf("%f", &a);
    printf("Enter coefficient b: ");
    scanf("%f", &b);
    printf("Enter coefficient c: ");
    scanf("%f", &c);

    discriminant = b * b - 4 * a * c;

    if (a == 0) {
        printf("This is not a quadratic equation (a = 0).\n");
        if (b != 0) {
            printf("Linear equation: x = %.2f\n", -c / b);
        } else {
            if (c == 0) {
                printf("Infinite solutions.\n");
            } else {
                printf("No solution.\n");
            }
        }
    } else {
        if (discriminant > 0) {
            x1 = (-b + sqrt(discriminant)) / (2 * a);
            x2 = (-b - sqrt(discriminant)) / (2 * a);
            printf("Two distinct real roots:\n");
            printf("x1 = %.2f\n", x1);
            printf("x2 = %.2f\n", x2);
        } else if (discriminant == 0) {
            x1 = -b / (2 * a);
            printf("One real root (double root):\n");
            printf("x = %.2f\n", x1);
        } else {
            printf("No real roots (complex roots).\n");
        }
    }

    return 0;
}
