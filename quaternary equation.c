#include <math.h>
#include <stdio.h>
#include <stdbool.h>

int main() {
    while (true) {
        int choice;
        float score;

        // Display menu options
        printf("1. Exercise 1: Calculate student's academic performance\n");
        printf("2. Exercise 2.1: Solve linear equation\n");
        printf("3. Exercise 2.2: Solve quadratic equation\n");
        printf("4. Exercise 3: Calculate electricity bill\n");
        printf("5. Exit\n");
        printf("Enter the exercise you want to view: ");
        scanf("%d", &choice);

        switch (choice) {
            case 1:
                // Calculate and display student's academic performance
                printf("Calculate student's academic performance\n");
                printf("Enter score: ");
                scanf("%f", &score);
                printf("Average score: %f\n", score);

                // Determine and print academic performance based on score
                if (score >= 9) {
                    printf("Academic performance: EXCELLENT\n");
                } else {
                    if (score >= 8) {
                        printf("Academic performance: GOOD\n");
                    } else {
                        if (score >= 6.5) {
                            printf("Academic performance: AVERAGE\n");
                        } else {
                            if (score >= 5) {
                                printf("Academic performance: BELOW AVERAGE\n");
                            } else {
                                if (score >= 3.5) {
                                    printf("Academic performance: WEAK\n");
                                } else {
                                    printf("Academic performance: VERY WEAK\n");
                                }
                            }
                        }
                    }
                }
                printf("Press Enter to continue.");
                getch();
                system("cls");
                break;

            case 2:
                // Solve and display linear equation
                printf("Solve linear equation\n");
                int a, b;
                printf("Enter a: ");
                scanf("%d", &a);
                printf("Enter b: ");
                scanf("%d", &b);

                // Check coefficients and calculate solution
                if (a == 0 && b == 0) {
                    printf("The equation has infinite solutions.\n");
                } else if (a == 0 && b != 0) {
                    printf("The equation has no solution.\n");
                } else {
                    float x = -b / (float)a;
                    printf("Solution of the equation: %.1f\n", x);
                }
                printf("Press Enter to continue.");
                getch();
                system("cls");
                break;

            case 3:
                // Solve and display quadratic equation
                printf("Solve quadratic equation\n");
                float a2, b2, c2;
                float delta, root1, root2;

                printf("Enter a: ");
                scanf("%f", &a2);
                printf("Enter b: ");
                scanf("%f", &b2);
                printf("Enter c: ");
                scanf("%f", &c2);

                delta = b2 * b2 - 4 * a2 * c2;

                if (a2 == 0) {
                    printf("Solution of the equation: %.1f\n", -c2 / b2);
                } else {
                    if (delta < 0) {
                        printf("The equation has no real solution.\n");
                    } else if (delta == 0) {
                        printf("The equation has a double root x = %.1f\n", -b2 / (2 * a2));
                    } else {
                        root1 = (-b2 + sqrt(delta)) / (2 * a2);
                        root2 = (-b2 - sqrt(delta)) / (2 * a2);
                        printf("The equation has two distinct real roots.\n");
                        printf("Root 1: %.1f\n", root1);
                        printf("Root 2: %.1f\n", root2);
                    }
                }
                printf("Press Enter to continue.");
                getch();
                system("cls");
                break;

            case 4:
                // Calculate and display electricity bill
                printf("Calculate electricity bill\n");
                float kWh, bill;

                printf("Enter electricity consumption (kWh): ");
                scanf("%f", &kWh);

                // Calculate bill based on consumption
                if (kWh < 0) {
                    printf("Invalid input. Please enter a non-negative value.\n");
                } else {
                    if (kWh <= 50) {
                        bill = kWh * 1678;
                    } else if (kWh <= 100) {
                        bill = 50 * 1678 + (kWh - 50) * 1734;
                    } else if (kWh <= 200) {
                        bill = 50 * 1678 + 50 * 1734 + (kWh - 100) * 2014;
                    } else if (kWh <= 300) {
                        bill = 50 * 1678 + 50 * 1734 + 100 * 2014 + (kWh - 200) * 2536;
                    } else if (kWh <= 400) {
                        bill = 50 * 1678 + 50 * 1734 + 100 * 2014 + 100 * 2536 + (kWh - 300) * 2834;
                    } else {
                        bill = 50 * 1678 + 50 * 1734 + 100 * 2014 + 100 * 2536 + 100 * 2834 + (kWh - 400) * 2927;
                    }
                    printf("Electricity bill: %.2f VND\n", bill);
                }
                printf("Press Enter to continue.");
                getch();
                system("cls");
                break;

            case 5:
                // Exit the program
                printf("Exiting the program.\n");
                return 0;

            default:
                // Handle invalid input
                printf("Invalid exercise choice. Please enter again.\n");
                printf("Press Enter to continue.");
                getch();
                system("cls");
        }
    }

    return 0;
}
