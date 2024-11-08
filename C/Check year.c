#include<stdio.h>

// Function to check if a year is a leap year
int checkLeapYear(int year) {
    int check = 0;
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
        check = 1;
    }
    return check;
}

int main() {
    printf("Leap Year Checker\n");
    int year;
    printf("Enter a year: ");
    scanf("%d", &year);

    int isLeapYear = checkLeapYear(year);

    if (isLeapYear == 1) {
        printf("%d is a leap year.", year);
    } else {
        printf("%d is not a leap year.", year);
    }

    return 0;
}
