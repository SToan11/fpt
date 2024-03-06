#include <stdio.h>
#include <string.h>

void swap(char str1[], char str2[]) {
    char temp[20];
    strcpy(temp, str1);
    strcpy(str1, str2);
    strcpy(str2, temp);
}
int main() {
    char s[5][20]; 
    int i, j; 
    for (i = 0; i < 5; i++) {
        printf("Nhap chuoi thu %d: ", i + 1);
        scanf("%s", s[i]);
    }
    for (i = 0; i < 4; i++) {
        for (j = 0; j < 4; j++) {
            if (strcmp(s[j], s[j + 1]) > 0) {
                swap(s[j], s[j + 1]);
            }
        }
    }
    printf("\nCac chuoi da sap xep:\n");
    for (i = 0; i < 5; i++) {
        printf("%s\n", s[i]);
    }
    return 0;
}

