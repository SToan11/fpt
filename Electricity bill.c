#include <stdio.h>

int main(){ 
 	float soDien, tienDien;
 	int bac1=1678, bac2=1734, bac3=2014, bac4=2536, bac5=2834, bac6=2927;
		printf("Nhap vao so dien (kWh): ");
		scanf("%f",&soDien);
		if(soDien<0){
		printf("Vui long nhap lai So Dien\nSo dien khong duoc nho hon 0\n");
		}else if(soDien<=50){
		tienDien=soDien*bac1;
		printf("so tien can tra: %.2f\n",tienDien);
		}else if(soDien<=100){
		tienDien=50*bac1+((soDien-50)*bac2);
		printf("so tien can tra: %.2f\n",tienDien);
		}else if(soDien<=200){
		tienDien=50*bac1+(50*bac2)+((soDien-100)*bac3);
		printf("so tien can tra: %.2f\n",tienDien);
		}else if(soDien<=300){
		tienDien=50*bac1+(50*bac2)+(100*bac3)+((soDien-200)*bac4);
		printf("so tien can tra: %.2f\n",tienDien);
		}else if(soDien<=400){
		tienDien=50*bac1+(50*bac2)+(100*bac3)+(100*bac4)+((soDien-300)*bac5);
		printf("so tien can tra: %.2f\n",tienDien);
		}else if(soDien>400){
		tienDien=50*bac1+(50*bac2)+(100*bac3)+(100*bac4)+(100*bac5)+((soDien-400)*bac6);
		printf("so tien can tra: %.2f\n",tienDien);
		}
	return 0;
}
