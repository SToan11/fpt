#include<stdio.h>

int checknamnhuan(int year) {
	int check = 0;
	if(year % 4 == 0 && year != 100 || year % 400 ==0){
		check = 1;
	}
	return check;
}

int main() {
	printf("Kiem tra nam nhuan \n");
	int y;
	printf("Nhap nam: "); scanf("%d", &y);
	int ck = checknamnhuan(y);
	if(ck == 1) {
		printf("%d la nam nhuan", y);
	}else{
		printf("%d khong phai nam nhuan", y);
	}
}
