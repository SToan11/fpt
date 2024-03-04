#include <stdio.h>
#include <math.h>

int main(){
	printf("kiem tra so nguyen to \n");
	int number;
	printf("Nhap so: ");
	scanf("%d", &number);
	int count = 0;
	if(number<2){
		printf("%d khong phai la so nguyen to", number);
	}
	int a =2;
	while(a<number){
		if(number % a == 0){
			count++;
		}
		a++;
	}
	if(count>0){
		printf("%d khong phai la so nguyen to ", number);
	}else{
		printf("%d la so nguyen to", number); 
	} 
}
