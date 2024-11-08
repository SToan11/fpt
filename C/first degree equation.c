#include<stdio.h>

int main(){
    printf("Solving linear equation bx + c = 0\n");
    float b, c, x;
    
    printf("Enter the value of b: ");
    scanf("%f", &b);
    
    printf("Enter the value of c: ");
    scanf("%f", &c);
    
    if(b == 0){
        if(c == 0){
            printf("The equation has infinitely many solutions");
        }else{
            printf("The equation has no solution");
        }
    }else{
        x = -c / b;
        printf("The solution is x = %f", x);
    }
    
    return 0;
}
