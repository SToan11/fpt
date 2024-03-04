#include <math.h>
#include <stdio.h>
#include <stdbool.h>
int main () {
	printf("Chuong trinh menu \n");
	int min, max;
	int chon=1;
	int number;
	int n;
	int i = 0;
	while(true){
		printf("1: Bai tap 1\n");
		printf("2: Bai tap 2\n");
		printf("3: Bai tap 3\n");
		printf("4: Ket thuc chuong trinh\n");
		printf("Moi ban chon:");
		scanf("%d", &chon);
		switch(chon){
			case 1: 
				printf("Tinh trung binh tong  cua cac  so tu nhien chia het cho 2\n");
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
				printf("bam enter de tiep tuc");
				getch();
				system("cls");
			break; 
			case 2:
				printf("kiem tra so nguyen to\n");
					printf("Nhap so: ");
					scanf("%d", &number);
					int count = 0;
					if(number<2){
						printf("%d khong phai la so nguyen to\n", number);
					}
					int a =2;
					while(a<number){
						if(number % a == 0){
							count++;
						}
						a++;
					}
					if(count>0){
						printf("%d khong phai la so nguyen to \n", number);
					}else{
						printf("%d la so nguyen to\n", number); 
					}  
					printf("bam enter de tiep tuc");
					getch();
					  system("cls");
			break;
			case 3:
					printf("Kiem tra so chinh phuong\n");
					printf("Nhap n = ");
					scanf("%d", &n);
					while(i*i <= n){
						if(i*i == n){
							printf("%d la so chinh phuong\n", n);
							return 0;
						}
						++i;
					}
					printf("%d khong phai so chinh phuong\n", n); 
					printf("bam enter de tiep tuc");
					getch();
					  system("cls");
			break;
			case 4: printf("Ket thuc \n"); 
			return 0;
			break;
		}
	}
}
