#include <stdio.h>
#include <math.h>
#include <stdbool.h>
//case 8
struct sinhVien {
    char tenSV[50];
    float diem;
    char hocLuc[15];
} dsSV[50], sv;
void NhapSV(struct sinhVien dsSV[], int n);
void XuatSV(struct sinhVien dsSV[], int n);
void SapXepSV(struct sinhVien dsSV[], int n);
void NhapSV(struct sinhVien dsSV[], int n) {
    int i;
    for (i = 0; i < n; i++) {
        fflush(stdin);
        printf("Nhap sinh vien %d\n", i + 1);
        printf("Ho ten: "); gets(dsSV[i].tenSV);
        printf("Nhap diem: "); scanf("%f", &dsSV[i].diem);
        if (dsSV[i].diem >= 9)
            strcpy(dsSV[i].hocLuc, "Xuat sac");
        else if (dsSV[i].diem >= 8)
            strcpy(dsSV[i].hocLuc, "Gioi");
        else if (dsSV[i].diem >= 6.5)
            strcpy(dsSV[i].hocLuc, "Kha");
        else if (dsSV[i].diem >= 5)
            strcpy(dsSV[i].hocLuc, "Trung Binh");
        else
            strcpy(dsSV[i].hocLuc, "Yeu");
    }
}
	
void SapXepSV(struct sinhVien dsSV[], int n) {
    int i, j;
    struct sinhVien temp;
    for (i = 0; i < n - 1; i++) {
        for (j = i + 1; j < n; j++) {
            if (dsSV[i].diem < dsSV[j].diem) {
                temp = dsSV[i];
                dsSV[i] = dsSV[j];
                dsSV[j] = temp;
            }
        }
    }
}
void XuatSV(struct sinhVien dsSV[], int n) {
    int i, stt = 1;
    printf("STT\tTen Sinh Vien\tDiem\t\tHoc luc\n");
    for (i = 0; i < n; i++) {
        printf("%d\t%s\t\t%.1f\t%s\n", stt++, dsSV[i].tenSV, dsSV[i].diem, dsSV[i].hocLuc);
    }
}
void thoat(){
	getch();
	system("cls");
}
int main(){
	while (true){
	printf ("_____________________TRAN SONG TOAN_______________________\n");
    printf ("____________________ASSIGNMENT COM108_____________________\n");
	printf ("+______________1.Bai 1: Kiem tra so nguyen_______________+\n");
	printf ("+_____2.Bai 2: Tim Uoc so chung va boi so chung 2 so_____+\n");
	printf ("+_____________3.Bai 3: Tinh tien quan Karaoke____________+\n");
	printf ("+________________4.Bai 4: Tinh tien dien_________________+\n");
	printf ("+______________6.Bai 6: Lai suat ngan hang_______________+\n");
	printf ("+__________8.Bai 8: Sap xep thong tin sinh vien__________+\n");
	printf ("+_____________10.Bai 10: Tinh toan phan so_______________+\n");
	printf ("+________________________11.Thoat._______________________+\n");
	printf ("----------------------------------------------------------\n");
	printf ("Nhap chuc nang muon xem: ");	
	int lock;
    scanf ("%d",&lock);
    float x,giodau,giocuoi,tonggio;
	int nt = 0;
	int y = 2;
	int l,c,a,b,uc,bc,n;
	float soDien, tienDien;
 	int bac1=1678, bac2=1734, bac3=2014, bac4=2536, bac5=2834, bac6=2927;
	switch (lock){
	  	case 1:
	  		printf("CHUC NANG 1: KIEM TRA SO NGUYEN\n");
	        printf("moi ban nhap so bat ky: "); scanf("%f", &x);
         	if(x==(int)x) {
	        	printf("%.0f la so nguyen\n", x);
		        int i=2, nt=0; 
		while (i<x){
			if((int)x%i==0) nt=1;
			i++;
	     	}
		if(nt==0) printf("%.0f la so NT va khong phai la so CP\n", x);
		else{
			printf("%.0f khong phai so NT\n", x);
			if(sqrt(x)==(int)sqrt(x)) printf ("%.0f la so CP\n",x);
			else printf ("%.0f khong phai la so CP\n",x);
		} 
        	} else printf("%.1f la so thuc\n", x);
	            printf ("Bam phim enter de tiep tuc");
               	thoat();
	        	break;
	    case 2:
	    	printf("CHUC NANG 2: TIM UCLL VA BCNN CUA 2 SO\n");
	    	printf ("nhap so muon tim uoc chung va boi chung\n");
	    	printf ("nhap a= ");
	    	scanf ("%d",&a);
	    	printf ("nhap b= ");
	    	scanf ("%d",&b);
	    	if (a<0||b<0){
	    		printf ("khong the tim duoc");
			} else {
	    	for (uc=a;uc>=1;uc--){
	    		if (a%uc==0&&b%uc==0){
	    			    printf ("UCLN(%d,%d)=%d\n",a,b,uc);
	    			    break;
				}
			}
			for (bc=a;bc<=a*b;bc++){
                if (bc%a==0 && bc%b==0){
                        printf("BCNN(%d,%d)=%d\n",a,b,bc);
                        break;
                }
            }
            }
			printf ("Bam phim enter de tiep tuc.");
			thoat();
			break;
	    case 3:{
	    	printf("CHUC NANG 3: TINH TIEN KARAOKE\n");
		    int giodau, giocuoi, tien, tonggio;
		    printf("Gio bat dau(12-22): "); scanf("%d", &giodau);
		    printf("Gio ket thuc(13-23): "); scanf("%d", &giocuoi);
		    if(giodau<11||giocuoi>=24||giodau>=giocuoi||giocuoi<=12) printf("Ban nhap khong dung\n");
			    else{
			    	tonggio=giocuoi-giodau;
			    	if(tonggio<=3) tien = 150000;
			    	else tien = 150000+(tonggio-3) * 50000 * 0.7;
			    	if(giodau>=14 && giodau<=17) tien*=0.9;
			    	printf("\nBan hat %d gio, tien hat = %d\n", giocuoi-giodau, tien);
			    }
			printf ("Bam phim enter de tiep tuc.");
		    thoat();
			}
		    break;
        case 4:
        	printf("CHUC NANG 4: TINH TIEN DIEN\n");
           	printf("Nhap vao so dien (kWh): ");
			scanf("%f",&soDien);
			if(soDien<0){
			printf("Vui long nhap lai So Dien\nSo dien khong duoc nho hon 0\n");
			}else if(soDien<=50){
			tienDien=soDien*bac1;
			printf("so tien can tra: %.0f Vnd\n",tienDien);
			}else if(soDien<=100){
			tienDien=50*bac1+((soDien-50)*bac2);
			printf("so tien can tra: %.0f Vnd\n",tienDien);
			}else if(soDien<=200){
			tienDien=50*bac1+(50*bac2)+((soDien-100)*bac3);
			printf("so tien can tra: %.0f Vnd\n",tienDien);
			}else if(soDien<=300){
			tienDien=50*bac1+(50*bac2)+(100*bac3)+((soDien-200)*bac4);
			printf("so tien can tra: %.0f Vnd\n",tienDien);
			}else if(soDien<=400){
			tienDien=50*bac1+(50*bac2)+(100*bac3)+(100*bac4)+((soDien-300)*bac5);
			printf("so tien can tra: %.0f Vnd\n",tienDien);
			}else if(soDien>400){
			tienDien=50*bac1+(50*bac2)+(100*bac3)+(100*bac4)+(100*bac5)+((soDien-400)*bac6);
			printf("so tien can tra: %.0f Vnd\n",tienDien);
			}
			printf ("Bam phim enter de tiep tuc.");
            thoat();
				break;
		case 6:{
			printf("CHUC NANG 6: TINH LAI SUAT VAY NGAN HANG VAY TRA GOP\n");
			int soTienVay;
			int soThang;
			float laiSuat = 0.05;
			int tienLai, kyhan = 0;
			printf("Nhap so tien cho vay: "); scanf("%d", &soTienVay);
			printf("Nhap so thang: "); scanf("%d", &soThang);
			int tienTraHangThang = soTienVay / soThang;
			printf("Ky han\tLai phai tra\tGoc phai tra\nSo tien phai tra\tSo tien con lai\n");
			while(soTienVay>0){
				if(soTienVay < 	tienTraHangThang)
					tienTraHangThang = soTienVay;
				tienLai = soTienVay*laiSuat;
				soTienVay -= tienTraHangThang;
				printf("%d\t%d\t%d\t%d\t%d\n", kyhan++, tienLai, tienTraHangThang, tienLai+tienTraHangThang, soTienVay );
			}
			printf ("Bam phim enter de tiep tuc.");
            getch( );
    	    system("cls");
			break;
		}
		case 8:{
			printf("CHUC NANG 8: SAP XEP THONG TIN SINH VIEN\n");
			printf("So sinh vien them: ");
			scanf("%d", &n);
			NhapSV(dsSV,n);
			SapXepSV(dsSV,n);
			XuatSV(dsSV,n);
			thoat();
			break;
		}
		case 10:{
			printf("CHUC NANG 10: CHUONG TRINH TINH TOAN PHAN SO\n");
		    thoat();
			break;
		}
	    case 11:
	    	printf ("Ban da thoat chuong trinh.\n");
	    	printf ("Bam phim enter de thoat.");
	    	return 0;
	    default:
			printf ("Bai khong ton tai\n");
			printf ("Bam phim enter de tiep tuc.");
            thoat();
	}
    }
}
