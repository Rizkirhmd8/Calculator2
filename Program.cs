#include <stdio.h>

int a = 10;
int b = 6;

static int penjumlahan(int a, int b){
    return a + b;
}
static int pengurangan(int a, int b){
    return a - b;
}
static int perkalian(int a, int b){
    return a * b;  
}
static int pembagian(int a, int b){
    return a / b;
}
static int modulus(int a, int b){
    return a % b;
}

int main()
{
    printf("Hasil Penjumlahan: \n", penjumlahan(a, b));
    printf("Hasil Pengurangan: \n", pengurangan(a, b));
    printf("Hasil Perkalian: \n", perkalian(a, b));
    printf("Hasil Pembagian: \n", pembagian(a, b));
    printf("Hasil Modulus  : \n", modulus(a, b));

    return 0;
}
