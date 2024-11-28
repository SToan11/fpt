#include <stdio.h>

// Define a structure to represent a student
struct Student {
    char mssv[50];      // Student ID
    char tenSV[50];     // Student name
    char nganhHoc[50];  // Major
    float diemTB;       // GPA
} studentArray[50];     // Array of student structures

// Function to swap two student records
void swap(struct Student *a, struct Student *b) {
    struct Student temp = *a;
    *a = *b;
    *b = temp;
}

int main() {
    int i, j, n; // Loop variables and number of students

    // Prompt the user to input the number of students to add
    printf("Enter the number of students to add: ");
    scanf("%d", &n);

    // Input information for each student
    for (i = 0; i < n; i++) {
        printf("\nEnter information for student %d:\n", i + 1);
        printf("Student ID: ");
        scanf("%s", studentArray[i].mssv);
        printf("Student Name: ");
        scanf("%s", studentArray[i].tenSV);
        printf("Major: ");
        scanf("%s", studentArray[i].nganhHoc);
        printf("GPA: ");
        scanf("%f", &studentArray[i].diemTB);
    }

    // Sort student records based on GPA using bubble sort algorithm
    for (i = 0; i < n - 1; i++) {
        for (j = 0; j < n - 1 - i; j++) {
            if (studentArray[j].diemTB > studentArray[j + 1].diemTB) {
                swap(&studentArray[j], &studentArray[j + 1]);
            }
        }
    }

    // Display information of all students after sorting by GPA
    printf("\nInformation of all students after sorting by GPA in ascending order:\n");
    for (i = 0; i < n; i++) {
        printf("Student %d:\n", i + 1);
        printf("Student ID: %s\n", studentArray[i].mssv);
        printf("Student Name: %s\n", studentArray[i].tenSV);
        printf("Major: %s\n", studentArray[i].nganhHoc);
        printf("GPA: %.2f\n", studentArray[i].diemTB);
        printf("\n");
    }

    return 0; // Exit the program
}
