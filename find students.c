#include <stdio.h>
#include <string.h>
struct SinhVien {
    char mssv[50];
    char tenSV[50];
    char nganhHoc[50];
    float diemTB;
} mangSV[50]; 
int main() {
    int i, j, n;
    printf("Nhap so sinh vien moi them: ");
    scanf("%d", &n);
    for (i = 0; i < n; i++) {
        printf("Nhap thong tin cho sinh vien %d:\n", i + 1);
        printf("MSSV: ");
        scanf("%s", mangSV[i].mssv);
        printf("Ten SV: ");
        scanf("%s", mangSV[i].tenSV);
        printf("Nganh hoc: ");
        scanf("%s", mangSV[i].nganhHoc);
        printf("Diem TB: ");
        scanf("%f", &mangSV[i].diemTB);
    }
    printf("\nThong tin cua tat ca sinh vien:\n");
    for (i = 0; i < n; i++) {
        printf("MSSV: %s\n", mangSV[i].mssv);
        printf("Ten SV: %s\n", mangSV[i].tenSV);
        printf("Nganh hoc: %s\n", mangSV[i].nganhHoc);
        printf("Diem TB: %.2f\n", mangSV[i].diemTB);
        printf("\n");
    }
    for (i = 0; i < n; i++) {
        for (j = i + 1; j < n; j++) {
            if (mangSV[i].diemTB < mangSV[j].diemTB) {
                struct SinhVien svTemp = mangSV[i];
                mangSV[i] = mangSV[j];
                mangSV[j] = svTemp;
            }
        }
    }
    printf("\nThong tin sinh vien sau khi sap xep theo diem TB tang dan:\n");
    for (i = 0; i < n; i++) {
        printf("MSSV: %s\n", mangSV[i].mssv);
        printf("Ten SV: %s\n", mangSV[i].tenSV);
        printf("Nganh hoc: %s\n", mangSV[i].nganhHoc);
        printf("Diem TB: %.2f\n", mangSV[i].diemTB);
        printf("\n");
    }
    char mssv[50];
    printf("Nhap MSSV can tim: ");
    scanf("%s", mssv);
    for (i = 0; i < n; i++) {
        if (strcmp(mangSV[i].mssv, mssv) == 0) {
            printf("\nThong tin cua sinh vien co MSSV %s:\n", mssv);
            printf("MSSV: %s\n", mangSV[i].mssv);
            printf("Ten SV: %s\n", mangSV[i].tenSV);
            printf("Nganh hoc: %s\n", mangSV[i].nganhHoc);
            printf("Diem TB: %.2f\n", mangSV[i].diemTB);
            break; 
        }
    }
    return 0;
}

