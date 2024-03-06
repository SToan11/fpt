#include<stdio.h>
char chuoi[100];
void nhap(){
	printf("Nhap vao 1 chuoi: ");
	gets(chuoi);
}
void xuat(){
	printf("Chuoi ban da nhap: ");
	puts(chuoi);
}
void demNguyenPhuAm(){
	int i = 0;
	int n = 0;
	int p = 0;
	while(chuoi[i] != '\0'){
		if(chuoi[i] == 'a' || chuoi[i] == 'i' || chuoi[i] == 'e' ||chuoi[i] == 'u' ||chuoi[i] == 'o'){
			n++;
		}else{
			p++;
		}
		i++ ;
	}
	printf("So luong nguyen am: %d \n", n);
	printf("So luong phu am: %d \n", p);
}
int main(){
	system("color 7");
	printf("In so nguyen am va phu am co trong chuoi \n");
	nhap();
	xuat();
	demNguyenPhuAm();
}
