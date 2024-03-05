#include<stdio.h>

int main (){
	int a[10],n=0;
	int i, j;
	printf ("Nhap phan tu cua mang: "); scanf ("%d",&n);
	printf ("Nhap so vao mang.\n");
	for (i=0;i<n;i++){
		printf ("a[%d]=",i); scanf ("%d",&a[i]);
	}
	for (i=0;i-n;i++){
		for (j=i;j<n;j++){
			if (a[i]<a[j]){
				int sd=a[i];
				a[i]=a[j];
				a[j]=sd;
			}
		}
	}
	printf ("Sap xep theo thu tu giam dan\n");
	for (i=0;i<n;i++){
		printf ("%d\n",a[i]);
	}
}
