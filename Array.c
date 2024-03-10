#include <stdio.h>

int main() {
    int a[10], n = 0;
    int i;
    printf("Enter the number of elements in the array: ");
    scanf("%d", &n);
    printf("Enter numbers into the array.\n");
    for (i = 0; i < n; i++) {
        printf("a[%d] = ", i);
        scanf("%d", &a[i]);
    }
    printf("Numbers divisible by 3 in the array.\n");
    for (i = 0; i < n; i++) {
        if (a[i] % 3 == 0) {
            printf("a[%d] = %d\n", i, a[i]);
        }
    }
    float sum = 0, avg;
    int count = 0;
    for (i = 0; i < n; i++) {
        if (a[i] % 3 == 0) {
            sum += a[i];
            count++;
        }
    }
    avg = sum / count;
    printf("\nThere are %d numbers divisible by 3", count);
    printf("\nSum: %.2f", sum);  
    printf("\nAverage: %.2f", avg);  
    return 0;
}
