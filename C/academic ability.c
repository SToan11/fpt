#include<stdio.h>

int main() {
    float grade;
    printf("Student's Academic Performance\n");
    printf("Enter grade: ");
    scanf("%f", &grade);
    printf("Average grade: %f\n", grade);

    if (grade >= 9) {
        printf("Excellent Academic Performance (XUAT SAC)");
    } else {
        if (grade >= 8) {
            printf("Good Academic Performance (GIOI)");
        } else {
            if (grade >= 6.5) {
                printf("Fairly Good Academic Performance (KHA)");
            } else {
                if (grade >= 5) {
                    printf("Average Academic Performance (TRUNG BINH)");
                } else {
                    if (grade >= 3.5) {
                        printf("Poor Academic Performance (YEU)");
                    } else {
                        printf("Very Poor Academic Performance (KEM)");
                    }
                }
            }
        }
    }
    return 0;
}
