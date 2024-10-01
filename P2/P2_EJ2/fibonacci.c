#include <stdio.h>
#include <time.h>
int Fibonacci(int n);
int main()
{
    printf("Programa que calcula la serie Fibonacci de un numero.\n\n");
    printf("Ingresa el numero del que deseas conocer la serie Fibonacci:");
    int num = 0;
    scanf("%d",&num);
    
    clock_t tiempo_inicio = clock();
    int resultado = Fibonacci(num);
    clock_t tiempo_final = clock();
    
    double tiempo_transcurrido = (double)(tiempo_final - tiempo_inicio) / CLOCKS_PER_SEC;
    printf("\nEl termino Fibonacci en la posicion %d es: %d\n",num, resultado);
    printf("Tiempo transcurrido: %f segundos\n", tiempo_transcurrido);
    
    return 0;
}
int Fibonacci(int n){
    if(n <= 1){
        printf("Non recursive case f{%d} = %d\n",n, n);
        return n;
    }
    else{
        printf("Recursive case f{%d} = f{%d} + f{%d}\n", n, n-1, n-2);
        return Fibonacci(n-1) + Fibonacci(n-2);
    }
}