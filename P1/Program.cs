int[] arregloNumeros = {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
int contadorIndicesDuplicados = 0;

Array.Sort(arregloNumeros);
int numeroMaximo = arregloNumeros[arregloNumeros.Length - 1];

Console.WriteLine("Arreglo de entrada:\n");
foreach (int numero in arregloNumeros){
    Console.Write($"{numero} ");
}

for(int i = 0; i < arregloNumeros.Length ; i++){
    for(int j = i + 1; j < arregloNumeros.Length; j++){
        if(arregloNumeros[j] == arregloNumeros[i]){
            arregloNumeros[j] = ++numeroMaximo;
            contadorIndicesDuplicados++;
        }
    }
}
Array.Sort(arregloNumeros);
Array.Resize(ref arregloNumeros, arregloNumeros.Length - contadorIndicesDuplicados);
Console.WriteLine("Resultados de salida:\n");
foreach (int numero in arregloNumeros){
    Console.Write($"{numero} ");
}
Console.WriteLine($"\nk: {arregloNumeros.Length}");