using System;
using System.Diagnostics;

/*Programa que une dos arreglos y calcula su media*/
int[] arreglo1 = {15, 11, 1, 5, 9, 6, 4};
int[] arreglo2 = {32, 12, 43, 3};
int[] arregloFusion = new int[arreglo1.Length + arreglo2.Length];
Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
Array.Sort(arreglo1);
Array.Sort(arreglo2);

Console.WriteLine("Arreglos entrantes:");

Console.WriteLine("Arreglo 1:");
ImprimirArreglo(arreglo1);
Console.WriteLine("\n\nArreglo 2:");
ImprimirArreglo(arreglo2);

arregloFusion = arreglo1.Concat(arreglo2).ToArray();
Array.Sort(arregloFusion);
stopwatch.Stop();

Console.WriteLine("\nArreglo resultante:");
ImprimirArreglo(arregloFusion);

if(arregloFusion.Length % 2 == 0){
    Console.WriteLine($"\n\nMediana del arreglo: {(arregloFusion[arregloFusion.Length / 2 - 1] + arregloFusion[arregloFusion.Length / 2]) / 2.0}");
}else{
    Console.WriteLine($"\n\nMediana del arreglo: {arregloFusion[arregloFusion.Length / 2]}");
}

Console.WriteLine($"Tiempo de ejecucion: {stopwatch.ElapsedMilliseconds} ms");

void ImprimirArreglo(int[] Arreglo){
    foreach(int elemento in Arreglo){
        Console.Write($"{elemento} ");
    }
}