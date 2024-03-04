#include<stdio.h>
int main() {
	printf("TRUNG BINH TONG CAC SO TU NHIEN CHIA HET CHO 2\n");
	int min, max;
	printf("Nhap min: ");
  	scanf("%d", &min);
  	printf("Nhap max: ");
  	scanf("%d", &max);
  	float tong = 0;
  	float dem = 0;
  	float trungBinh = 0;
  	int i = min;  
  	while(i <= max) { 
    if(i % 2 == 0) {
      tong += i;
      dem++;
    }
    i++; 
  	}
  trungBinh = tong / dem;
  printf("Trung binh tong cac so tu nhien chia het cho 2 tu %d - %d = %f \n", min, max, trungBinh);
  return 0;
}
