#include <stdio.h>

int main() {
    printf("PERIMETER AND AREA OF A RECTANGLE:\n");

    float perimeter, area, length, width;

    // Input length and width of the rectangle
    printf("Enter the length: ");
    scanf("%f", &length);
    printf("Enter the width: ");
    scanf("%f", &width);

    // Calculate perimeter and area
    perimeter = 2 * (length + width);
    area = length * width;

    // Print the calculated perimeter and area
    printf("Perimeter: %f\n", perimeter);
    printf("Area: %f\n", area);

    return 0;
}
