#include<stdio.h>

// Function to swap two integers using pointers
void swap(int *a, int *b){
    int temp = *a; // Store the value of a in temp
    *a = *b; // Assign the value of b to a
    *b = temp; // Assign the value of temp (initial a) to b
}

int main() {
    printf("Swap Function\n");

    int a, b;
    printf("Enter value for a: ");
    scanf("%d", &a);
    printf("Enter value for b: ");
    scanf("%d", &b);

    printf("Before swap: a = %d, b = %d\n", a, b);

    // Call the swap function to swap the values of a and b
    swap(&a, &b);

    printf("After swap: a = %d, b = %d\n", a, b);

    return 0;
}
