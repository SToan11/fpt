#include<stdio.h>
int main() {
	float diem;
	printf("In hoc luc sinh vien\n");
	printf("Nhap diem: ");
	scanf("%f", &diem);
	printf("Diem trung binh :%f\n", diem);
	if(diem >=9){
		printf("Hoc luc XUAT SAC");
	}else{
		if(diem>=8){
			printf("Hoc luc GIOI");
		}else{
			if(diem>=6.5){
				printf("Hoc luc KHA");
			}else{
				if(diem>=5){
					printf("Hoc luc TRUNG BINH");
				}else{
					if(diem>=3.5){
						printf("Hoc luc YEU");
					}else{
						printf("Hoc luc KEM");
					}
				}
			}
		}
	}
	return 0;
}
