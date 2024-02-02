#include<stdio.h>
int main(){
	float bk, cv, dt;
	const float PI = 3.14;
	printf("nhap vao ban kinh:");
	scanf("%f", &bk);
	cv = 2 * PI * bk;
	dt = bk * bk * PI;
	printf("Chu vi: %f \n", cv);
	printf("Dien tich: %f", dt);	
	return 0;
}
