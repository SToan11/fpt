#include<stdio.h>

int main() {
    printf("AVERAGE OF SUMS OF NATURAL NUMBERS DIVISIBLE BY 2\n");
    
    // Declare variables to store the minimum and maximum values
    int min, max;
    
    // Prompt the user to input the minimum value
    printf("Enter min: ");
    scanf("%d", &min);
    
    // Prompt the user to input the maximum value
    printf("Enter max: ");
    scanf("%d", &max);
    
    // Initialize variables to store the sum, count, and average
    float sum = 0;
    float count = 0;
    float average = 0;
    
    // Iterate through the range from min to max
    int i = min;
    while (i <= max) {
        // Check if the current number is divisible by 2
        if (i % 2 == 0) {
            // If divisible by 2, add it to the sum and increment the count
            sum += i;
            count++;
        }
        i++;
    }
    
    // Calculate the average of the sums
    average = sum / count;
    
    // Display the result
    printf("Average of sums of natural numbers divisible by 2 from %d to %d = %f\n", min, max, average);
    
    return 0;
}
