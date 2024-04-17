#include <stdio.h>
#include <math.h>

int main() {
    int a, b;

    // Prompt the user to input the first number
    printf("Enter the first number: ");
    scanf("%d", &a);

    // Prompt the user to input the second number
    printf("Enter the second number: ");
    scanf("%d", &b);

    // Calculate the sum of the two numbers
    int sum = a + b;

    // Calculate the difference of the two numbers
    int difference = a - b;

    // Display the sum of the two numbers
    printf("The sum of the two numbers is: %d\n", sum);

    // Display the difference of the two numbers
    printf("The difference of the two numbers is: %d\n", difference);

    return 0; // Exit the program
}
