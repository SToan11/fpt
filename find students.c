#include <stdio.h>
#include <string.h>

struct SinhVien {
    char mssv[50];
    char tenSV[50];
    char nganhHoc[50];
    float diemTB;
} mangSV[50]; 

int main() {
    int i, j, n;

    printf("Enter the number of students to add: ");
    scanf("%d", &n);

    // Input student information
    for (i = 0; i < n; i++) {
        printf("Enter information for student %d:\n", i + 1);
        printf("Student ID: ");
        scanf("%s", mangSV[i].mssv);
        printf("Student Name: ");
        scanf("%s", mangSV[i].tenSV);
        printf("Major: ");
        scanf("%s", mangSV[i].nganhHoc);
        printf("Average Score: ");
        scanf("%f", &mangSV[i].diemTB);
    }

    // Display all students' information
    printf("\nInformation of all students:\n");
    for (i = 0; i < n; i++) {
        printf("Student ID: %s\n", mangSV[i].mssv);
        printf("Student Name: %s\n", mangSV[i].tenSV);
        printf("Major: %s\n", mangSV[i].nganhHoc);
        printf("Average Score: %.2f\n", mangSV[i].diemTB);
        printf("\n");
    }

    // Sort students based on average score in ascending order
    for (i = 0; i < n; i++) {
        for (j = i + 1; j < n; j++) {
            if (mangSV[i].diemTB > mangSV[j].diemTB) {
                struct SinhVien svTemp = mangSV[i];
                mangSV[i] = mangSV[j];
                mangSV[j] = svTemp;
            }
        }
    }

    // Display sorted students' information
    printf("\nInformation of students sorted by average score in ascending order:\n");
    for (i = 0; i < n; i++) {
        printf("Student ID: %s\n", mangSV[i].mssv);
        printf("Student Name: %s\n", mangSV[i].tenSV);
        printf("Major: %s\n", mangSV[i].nganhHoc);
        printf("Average Score: %.2f\n", mangSV[i].diemTB);
        printf("\n");
    }

    // Search for a student by their student ID
    char mssv[50];
    printf("Enter the student ID to search: ");
    scanf("%s", mssv);
    for (i = 0; i < n; i++) {
        if (strcmp(mangSV[i].mssv, mssv) == 0) {
            printf("\nInformation of student with ID %s:\n", mssv);
            printf("Student ID: %s\n", mangSV[i].mssv);
            printf("Student Name: %s\n", mangSV[i].tenSV);
            printf("Major: %s\n", mangSV[i].nganhHoc);
            printf("Average Score: %.2f\n", mangSV[i].diemTB);
            break; // Stop searching once the student is found
        }
    }

    return 0;
}
