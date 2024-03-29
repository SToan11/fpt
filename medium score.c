#include<stdio.h>

int main() {
    printf("PROGRAM TO CALCULATE AVERAGE SCORE:\n");

    // Declare variables to store scores and average
    float math, physics, chemistry, totalScore, averageScore;

    // Input scores for math, physics, and chemistry
    printf("Enter math score: ");
    scanf("%f", &math);
    printf("Enter physics score: ");
    scanf("%f", &physics);
    printf("Enter chemistry score: ");
    scanf("%f", &chemistry);

    // Calculate total score and average score
    totalScore = math + physics + chemistry;
    averageScore = totalScore / 3;

    // Print total score and average score
    printf("Total score: %f\n", totalScore);
    printf("Average score: %f", averageScore);

    return 0;
}
