#include <stdio.h>
#include <string.h>

// Function to swap two strings
void swap(char str1[], char str2[]) {
    char temp[20];
    strcpy(temp, str1); // Copy contents of str1 to temp
    strcpy(str1, str2); // Copy contents of str2 to str1
    strcpy(str2, temp); // Copy contents of temp to str2
}

int main() {
    char s[5][20]; // Array to store 5 strings, each of maximum length 20
    int i, j; // Loop counters
    
    // Input 5 strings from the user
    for (i = 0; i < 5; i++) {
        printf("Enter string %d: ", i + 1); // Prompt the user to enter a string
        scanf("%s", s[i]); // Read the string and store it in the array
    }
    
    // Bubble sort to sort the strings in ascending order
    for (i = 0; i < 4; i++) {
        for (j = 0; j < 4; j++) {
            // Compare adjacent strings and swap them if they're out of order
            if (strcmp(s[j], s[j + 1]) > 0) {
                swap(s[j], s[j + 1]); // Call the swap function
            }
        }
    }
    
    // Print the sorted strings
    printf("\nSorted strings:\n");
    for (i = 0; i < 5; i++) {
        printf("%s\n", s[i]); // Print each string in the array
    }
    
    return 0; // Exit the program
}
