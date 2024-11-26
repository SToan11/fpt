#include <stdio.h>

int main(){
    printf("Prime Number Checker\n");
    int number;
    printf("Enter a number: ");
    scanf("%d", &number);
    int count = 0;

    if(number < 2){
        printf("%d is not a prime number", number);
    } else {
        int divisor = 2;
        while(divisor < number){
            if(number % divisor == 0){
                count++;
            }
            divisor++;
        }
        if(count > 0){
            printf("%d is not a prime number", number);
        } else {
            printf("%d is a prime number", number); 
        } 
    }

    return 0;
}
