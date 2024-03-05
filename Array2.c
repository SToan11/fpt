#include<stdio.h>

int main (){
	int a[10],n=0;
	printf ("nhap phan tu cua mang: "); scanf ("%d",&n);
	printf ("nhap so vao mang.\n");
	int i;
	for (i=0;i<n;i++){
		printf ("a[%d]=",i); scanf ("%d",&a[i]);
	}
	int max=a[0];
	for (i=0;i<n;i++){
		if (a[i]>max){
			max=a[i];
		}
	}
	printf ("so lon nhat trong mang la: %d\n",max);
	int min=a[0];
	for (i=0;i<n;i++){
		if (a[i]<min){
			min=a[i];
		}
	}
	printf ("so nho nhat trong mang la: %d",min);
}
