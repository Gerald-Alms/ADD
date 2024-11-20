using System;
// Programa que recibe un arreglo unidimensional y lo divide
// en subarreglos en base a una cantidad de elementos y a un promedio 
// ambos ingresados manualmente
int[] arr = { 2, 2, 2, 2, 5, 5, 5, 8 };
int k = 3;
int threshold = 4;

Console.WriteLine("Arreglo de entrada: ");
foreach (int elemento in arr){
    Console.Write($"{elemento} ");
}
Console.WriteLine();

int resultado = NumSubArreglos(arr, k, threshold);

Console.WriteLine("\nNúmero de subarreglos con promedio >= " + threshold + ": " + resultado);

int NumSubArreglos(int[] arr, int k, int threshold){
    int n = arr.Length;
    int cont = 0;
    int sumaActual = 0;

    // Sumar los primeros k elementos
    for (int i = 0; i < k; i++){
        sumaActual += arr[i];
    }

    // Verificar si el promedio del primer subarreglo cumple con el umbral
    if ((double)sumaActual / k >= threshold){
        cont++;
        ImprimirSubarreglo(arr, 0, k);
    }

    // Deslizar la ventana a través del arreglo
    for (int i = k; i < n; i++){
        sumaActual = sumaActual - arr[i - k] + arr[i];

        // Verificar si el promedio cumple con el umbral
        if ((double)sumaActual / k >= threshold){
            cont++;
            ImprimirSubarreglo(arr, i - k + 1, k);
        }
    }

    return cont;
}

void ImprimirSubarreglo(int[] arr, int inicio, int tamaño){
    Console.Write("[");
    for (int i = inicio; i < inicio + tamaño; i++){
        Console.Write(arr[i]);
        if (i < inicio + tamaño - 1){
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}