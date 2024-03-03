//pt bac 2
#include<stdio.h>
int main(){
	printf("GIAI PHUONG TRINH BAC 2\n");
	float d,x1,x2,n1,n2,n3;
	int a,b;
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
	return 0;
}
