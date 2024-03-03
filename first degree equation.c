//bx+c=0
#include<stdio.h>
int main(){
	printf("Giai phuong trinh bac 1\n");
	float b, c, x;
	printf("nhap b: ");
	scanf("%f", &b);
	printf("nhap c: ");
	scanf("%f", &c);
	if(b == 0){
		if(c==0){
			printf("phuong trinh vo so nghiem");
		}else{
			printf("phuong trinh vo nghiem");
		}
	}else{
	x = -c/b;
	printf("Nghiem x =%f", x);
	}
	return 0;
}
