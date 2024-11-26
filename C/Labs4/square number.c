#include <stdio.h>

int main(){
    int n;
    printf("Enter n = "); // Prompt the user to enter a value for n
    scanf("%d", &n); // Read an integer input from the user and store it in n
    int i = 0; // Initialize a loop counter i to 0

    // Start a loop that continues as long as the square of i is less than or equal to n
    while(i*i <= n){
        // Check if i*i is equal to n, indicating that n is a perfect square
        if(i*i == n){
            printf("%d is a perfect square\n", n); // Print that n is a perfect square
            return 0; // Exit the program
        }
        ++i; // Increment i for the next iteration
    }

    // If the loop completes without finding a perfect square (i*i > n),
    // it means that n is not a perfect square
    printf("%d is not a perfect square\n", n); // Print that n is not a perfect square
    return 0; // Exit the program
}
