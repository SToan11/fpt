#include<stdio.h>
int main (){
	printf("CHU VI DIEN TICH HCN:\n");
	float cv, dt, dai, rong;
	printf("nhap chieu dai:");
	scanf("%f", &dai);
	printf("nhap chieu rong:");
	scanf("%f", &rong);
	cv=2*(dai+rong);
	dt=(dai*rong);
	printf("chu vi: %f\n", cv);
	printf("dien tich: %f", dt);
}
