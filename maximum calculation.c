#include<stdio.h>

int max(int a, int b, int c){
	int max=a;
	if(b > max){
		max=b;
	}
	if(c>max) {
		max=c;
	}
	return max;
}

int main() {
	printf("Tim max a, b, c \n");
	int a, b, c;
	int solonnhat;
	printf("nhap a: "); scanf("%d", &a);
	printf("nhap b: "); scanf("%d", &b);
	printf("nhap c: "); scanf("%d", &c);
	solonnhat = max(a, b, c);
	printf("So lon nhat la: %d ", solonnhat);
}
