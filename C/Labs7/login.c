#include<stdio.h>
#include<string.h>

int main() {
    char name[100];
    printf("Enter username: ");
    gets(name); // Note: gets is discouraged due to potential buffer overflow, consider using fgets instead
    
    int pass;
    printf("Enter password: ");
    scanf("%d", &pass);

    if (strcmp(name, "admin") == 0 && pass == 123456) {
        printf("Login successful");
    } else {
        printf("Login failed");
    }

    return 0;
}
