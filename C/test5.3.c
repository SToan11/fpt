#include<stdio.h>

// Function to swap two integers using pointers
void swap(int *a, int *b) {
    int temp = *a; // Store the value of a in temp
    *a = *b;       // Assign the value of b to a
    *b = temp;     // Assign the value of temp to b
}

int main() {
    int a, b;
    
    // Prompt the user to input the first number
    printf("Enter the value of a: ");
    scanf("%d", &a);
    
    // Prompt the user to input the second number
    printf("Enter the value of b: ");
    scanf("%d", &b);
    
    // Display the numbers before swapping
    printf("Before swapping: a = %d, b = %d\n", a, b);
    
    // Call the swap function to swap the values of a and b
    swap(&a, &b);
    
    // Display the numbers after swapping
    printf("After swapping: a = %d, b = %d\n", a, b);
    
    return 0; // Exit the program
}
