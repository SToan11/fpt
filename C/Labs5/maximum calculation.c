#include<stdio.h>

// Function to find the maximum of three integers
int max(int a, int b, int c){
    int max = a; // Assume a is the maximum initially
    if (b > max) {
        max = b; // Update max if b is greater than max
    }
    if (c > max) {
        max = c; // Update max if c is greater than max
    }
    return max; // Return the maximum value
}

int main() {
    printf("Find the maximum of a, b, c\n");
    int a, b, c;
    int maxNumber; // Variable to store the maximum value

    printf("Enter a: ");
    scanf("%d", &a);
    printf("Enter b: ");
    scanf("%d", &b);
    printf("Enter c: ");
    scanf("%d", &c);

    maxNumber = max(a, b, c); // Call the max function to find the maximum

    printf("The maximum number is: %d", maxNumber); // Print the maximum value

    return 0;
}
