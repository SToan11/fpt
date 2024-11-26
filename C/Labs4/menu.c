#include <stdio.h>
#include <stdbool.h>

int main() {
    printf("Menu Program\n");

    int min, max;
    int choice = 1;
    int number;
    int n;
    int i = 0;

    while (true) {
        printf("1: Exercise 1\n");
        printf("2: Exercise 2\n");
        printf("3: Exercise 3\n");
        printf("4: Exit the program\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch (choice) {
            case 1:
                printf("Calculate the average sum of natural numbers divisible by 2\n");
                printf("Enter min: ");
                scanf("%d", &min);
                printf("Enter max: ");
                scanf("%d", &max);

                float sum = 0;
                float count = 0;
                float average = 0;
                i = min;
                while (i <= max) {
                    if (i % 2 == 0) {
                        sum += i;
                        count++;
                    }
                    i++;
                }
                average = sum / count;
                printf("Average sum of natural numbers divisible by 2 from %d to %d = %f\n", min, max, average);
                printf("Press Enter to continue");
                getchar(); // Clear newline character
                getchar(); // Wait for Enter key
                system("clear"); // Clear console (for Unix-like systems)
                break;

            case 2:
                printf("Check prime numbers\n");
                printf("Enter a number: ");
                scanf("%d", &number);

                int primeCount = 0;
                if (number < 2) {
                    printf("%d is not a prime number\n", number);
                } else {
                    int divisor = 2;
                    while (divisor < number) {
                        if (number % divisor == 0) {
                            primeCount++;
                        }
                        divisor++;
                    }
                    if (primeCount > 0) {
                        printf("%d is not a prime number\n", number);
                    } else {
                        printf("%d is a prime number\n", number);
                    }
                }
                printf("Press Enter to continue");
                getchar(); // Clear newline character
                getchar(); // Wait for Enter key
                system("clear"); // Clear console (for Unix-like systems)
                break;

            case 3:
                printf("Check perfect square numbers\n");
                printf("Enter n: ");
                scanf("%d", &n);

                i = 0;
                while (i * i <= n) {
                    if (i * i == n) {
                        printf("%d is a perfect square\n", n);
                        break;
                    }
                    i++;
                }
                if (i * i != n) {
                    printf("%d is not a perfect square\n", n);
                }
                printf("Press Enter to continue");
                getchar(); // Clear newline character
                getchar(); // Wait for Enter key
                system("clear"); // Clear console (for Unix-like systems)
                break;

            case 4:
                printf("Exiting program\n");
                return 0;

            default:
                printf("Invalid choice, please try again\n");
                break;
        }
    }

    return 0;
}
