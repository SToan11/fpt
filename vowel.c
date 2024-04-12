#include<stdio.h>

// Declare a global character array to store the input string
char chuoi[100];

// Function to input a string
void nhap(){
    printf("Enter a string: ");
    gets(chuoi); // Read a string with spaces using gets() function
}

// Function to output the input string
void xuat(){
    printf("You entered: ");
    puts(chuoi); // Display the input string using puts() function
}

// Function to count vowels and consonants
void demNguyenPhuAm(){
    int i = 0;
    int vowels = 0;
    int consonants = 0;
    
    // Loop through the characters of the string until the null character is encountered
    while(chuoi[i] != '\0'){
        // Check if the current character is a vowel
        if(chuoi[i] == 'a' || chuoi[i] == 'e' || chuoi[i] == 'i' || chuoi[i] == 'o' || chuoi[i] == 'u'){
            vowels++; // Increment the vowel count
        } else {
            consonants++; // Increment the consonant count
        }
        i++; // Move to the next character
    }
    
    // Output the counts of vowels and consonants
    printf("Number of vowels: %d\n", vowels);
    printf("Number of consonants: %d\n", consonants);
}

int main(){
    system("color 7"); // Change the console color
    printf("Count vowels and consonants in a string\n");
    nhap(); // Input a string
    xuat(); // Output the input string
    demNguyenPhuAm(); // Count vowels and consonants
    return 0;
}
