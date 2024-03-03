#include <math.h>
#include <stdio.h>
#include <stdbool.h>
int main () {
	while (true){
	int so; 
	float diem;
	printf ("1.Bai 1: tinh hoc luc              \n");
	printf ("2.Bai 2.1: giai phuong trinh bac 1 \n");
	printf ("3.Bai 2.2: giai phuong trinh bac 2 \n");
	printf ("4.Bai 3: tinh tien dien            \n");
	printf ("5.thoat                            \n");
	printf ("nhap bai muon xem: ");
        scanf ("%d",&so);
		switch (so) {
	float toan, ly, hoa,d,x1,x2,n1,n2,n3,dien;		
		int a,b;
	float soDien, tienDien;
 	int bac1=1678, bac2=1734, bac3=2014, bac4=2536, bac5=2834, bac6=2927;
			case 1:
				printf("In hoc luc sinh vien\n");
				printf("Nhap diem: ");
				scanf("%f", &diem);
				printf("Diem trung binh :%f\n", diem);
				if(diem >=9){
					printf("Hoc luc XUAT SAC\n");
				}else{
					if(diem>=8){
						printf("Hoc luc GIOI\n");
					}else{
						if(diem>=6.5){
							printf("Hoc luc KHA\n");
						}else{
							if(diem>=5){
								printf("Hoc luc TRUNG BINH\n");
							}else{
								if(diem>=3.5){
									printf("Hoc luc YEU\n");
								}else{
									printf("Hoc luc KEM\n");
								}
							}
						}
					}
				}
				printf ("Bam phim enter de tiep tuc.");
	            getch( );
		        system("cls");
			break;
			case 2:
				printf("GIAI PHUONG TRINH BAC 1\n");
				printf ("nhap a= ");
				scanf ("%d",&a);
				printf ("nhap b= ");				
				scanf ("%d",&b);
				if (a==0&b==0) {
					printf ("phuong trinh vo so nghiem");
				} else if(a==0&b!=0){
					printf ("phuong trinh vo nghiem");
						}
						float x=-b/a;
						printf ("nghiem cua phuong trinh= %.1f\n",x);
						printf ("Bam phim enter de tiep tuc.");
	      	          	getch( );
				        system("cls");
						break;
			case 3:
				printf("GIAI PHUONG TRINH BAC 2\n");
	            printf ("nhap a= ");
				scanf ("%f",&n1);
				printf ("nhap b= ");
				scanf ("%f",&n2);
				printf ("nhap c= ");
				scanf ("%f",&n3);
				d=(n2*2)-4*(n1*n3);
				x1=(-n2+sqrt(d))/(2*n1);
				x2=(-n2-sqrt(d))/(2*n1);
				if (n1==0) {
					printf ("nghiem cua phuong trinh= %.1f\n",-n3/n2);
				} else if (n1!=0) {
					printf ("delta cua phuong trinh= %.1f\n",d);
				  if (d<0) {       
					printf ("phuong trinh vo nghiem\n");
				} else if (d==0) {
					printf ("phuong trinh co nghiem kep x = %.1f\n",-b/(2*n1));
				} else if (d>0) {
					printf ("phuong trinh co hai nghiem rieng biet\n");
					printf ("x1= %.1f\n",x1);
					printf ("x2= %.1f\n",x2);
				}
				} 
				printf ("Bam phim enter de tiep tuc.");
                getch( );
	            system("cls");
				break;
			case 4:
		printf("Nhap vao so dien (kWh): ");
		scanf("%f",&soDien);
		if(soDien<0){
			printf("Vui long nhap lai So Dien\nSo dien khong duoc nho hon 0\n");
		}else 	if(soDien<=50){
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
									getch( );
    								system("cls");
	    							break;
	            case 5:
				printf ("ban da thoat chuong trinh");
				return 0;
			default:
				printf ("khong co bai do xin moi nhap lai\n");
				printf ("Bam phim enter de tiep tuc.");
                getch( );
	            system("cls");
		}
	}
}

