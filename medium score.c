#include<stdio.h>
int main() {
	printf("CHUONG TRINH TINH DIEM TRUNG BINH:\n");
	float toan, li, hoa, tongdiem, tbc;
	printf("Nhap diem toan: ");
	scanf("%f", &toan);
	printf("Nhap diem li: ");
	scanf("%f", &li);
	printf("Nhap diem hoa: ");
	scanf("%f", &hoa);
	tongdiem = toan + li + hoa;
	tbc = tongdiem/3;
	printf("tong diem: %f\n", tongdiem);
	printf("trung binh: %f", tbc);
	return 0;
}
