#include<stdio.h>

int main() {
	int i, j,n=0,m=0;;
	printf ("Nhap phan tu cua mang: "); scanf ("%d",&n);
	printf ("Nhap phan tu cua mang: "); scanf ("%d",&m);
	int a[n][m];
	printf ("Nhap so vao mang.\n");
	for (i=0;i<n;i++){
		for (j=0;j<m;j++){
			printf ("a[%d][%d]= ",i,j); scanf ("%d",&a[i][j]);
		}
	}
	for (i=0;i<n;i++){
		for (j=0;j<m;j++){
			a[i][j]=a[i][j]*a[i][j];
		}
	}
	printf ("mang sau khi binh phuong: \n");
	for(i=0;i<n;i++){
	for(j=0;j<m;j++){
	     printf ("a[%d][%d]=%d\n",i,j,a[i][j]);
	}
	}
	
}
