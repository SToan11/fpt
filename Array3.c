#include<stdio.h>

int main (){
    int a[10], n=0;
    int i, j;
    printf ("Enter the number of elements in the array: "); scanf ("%d",&n);
    printf ("Enter numbers into the array.\n");
    for (i=0; i<n; i++){
        printf ("a[%d]=",i); scanf ("%d",&a[i]);
    }
    for (i=0; i<n; i++){
        for (j=i; j<n; j++){
            if (a[i]<a[j]){
                int temp=a[i];
                a[i]=a[j];
                a[j]=temp;
            }
        }
    }
    printf ("Array sorted in descending order\n");
    for (i=0; i<n; i++){
        printf ("%d\n",a[i]);
    }
}
