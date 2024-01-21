#include<stdio.h>
void clow(int *a, int *b){
	int sd;
	sd=*a;
	*a=*b;
	*b=sd;
}
	int main (){
	printf("Ham hoan vi \n");
	int a,b;
	printf ("nhap so a: ");
	scanf ("%d",&a);
	printf ("nhap so b: ");
	scanf ("%d",&b);
	printf ("chuong trinh hoan vi\n");
	printf ("truoc hoan vi: %d - %d\n",a,b);
	clow(&a,&b);
	printf ("sau khi hoan vi: %d - %d",a,b);
}


