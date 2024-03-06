#include<stdio.h>
#include <string.h>
int main (){
	char name[100];
	printf ("Nhap ten dang nhap: "); gets(name);
	int pass;
	printf ("Nhap mat khau: "); scanf ("%d",&pass);
	if (strcmp(name,"admin")==0&&pass == 123456) 
		printf ("Dang nhap thanh cong");
	else 
		printf ("Dang nhap that bai");
		return 0;
}

