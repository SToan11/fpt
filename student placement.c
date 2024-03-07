#include <stdio.h>

// T?o ki?u d? li?u sinh viên
struct SinhVien {
    char mssv[50];
    char tenSV[50];
    char nganhHoc[50];
    float diemTB;
} mangSV[50]; 
void swap(struct SinhVien *a, struct SinhVien *b) {
    struct SinhVien temp = *a;
    *a = *b;
    *b = temp;
}

int main() {
    int i, j, n; 
    printf("Nhap so sinh vien moi them: ");
    scanf("%d", &n);
    for (i = 0; i < n; i++) {
        printf("Nhap thong tin cho sinh vien thu %d:\n", i + 1);
        printf("MSSV: ");
        scanf("%s", mangSV[i].mssv);
        printf("Ten SV: ");
        scanf("%s", mangSV[i].tenSV);
        printf("Nganh hoc: ");
        scanf("%s", mangSV[i].nganhHoc);
        printf("Diem trung binh: ");
        scanf("%f", &mangSV[i].diemTB);
    }

    for (i = 0; i < n - 1; i++) {
        for (j = 0; j < n - 1 - i; j++) {
            if (mangSV[j].diemTB > mangSV[j + 1].diemTB) {
                swap(&mangSV[j], &mangSV[j + 1]);
            }
        }
    }
    printf("\nThong tin cua tat ca sinh vien sau khi sap xep theo diem TB tang dan:\n");
    for (i = 0; i < n; i++) {
        printf("Sinh vien %d:\n", i + 1);
        printf("MSSV: %s\n", mangSV[i].mssv);
        printf("Ten SV: %s\n", mangSV[i].tenSV);
        printf("Nganh hoc: %s\n", mangSV[i].nganhHoc);
        printf("Diem trung binh: %.2f\n", mangSV[i].diemTB);
        printf("\n");
    }

    return 0;
}

