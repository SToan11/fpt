#include <stdio.h>

int main() {
    int a[10], n = 0;
    int i;
    printf("Nhap so phan tu cua mang: ");
    scanf("%d", &n);
    printf("Nhap so vao mang.\n");
    for (i = 0; i < n; i++) {
        printf("a[%d] = ", i);
        scanf("%d", &a[i]);
    }
    printf("Cac so chia het cho 3 trong mang.\n");
    for (i = 0; i < n; i++) {
        if (a[i] % 3 == 0) {
            printf("a[%d] = %d\n", i, a[i]);
        }
    }
    float tong = 0, tb;
    int count = 0;
    for (i = 0; i < n; i++) {
        if (a[i] % 3 == 0) {
            tong += a[i];
            count++;
        }
    }
    tb = tong / count;
    printf("\nCo %d so chia het cho 3", count);
    printf("\nTong: %.2f", tong);  
    printf("\nTrung binh: %.2f", tb);  
    return 0;
}

