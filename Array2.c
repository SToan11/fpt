#include<stdio.h>

int main (){
    int a[10],n=0;
    printf ("Enter the number of elements in the array: "); scanf ("%d",&n);
    printf ("Enter numbers into the array.\n");
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
    printf ("The maximum number in the array is: %d\n",max);
    int min=a[0];
    for (i=0;i<n;i++){
        if (a[i]<min){
            min=a[i];
        }
    }
    printf ("The minimum number in the array is: %d",min);
} 
