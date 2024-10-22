// Programa que mezcla k listas ordenadas, en una sola lista ordenada de manera ascendente
// mediante el uso de un min-heap (o cola de prioridad) a la lista final

// Ejemplo de arreglos:
int[][] listas = new int[][]{
            new int[] { 1, 4, 5 },
            new int[] { 1, 3, 4 },
            new int[] { 2, 6 }
};

Console.WriteLine("Listas antes de fusionar:");
for (int i = 0; i < listas.Length; i++){
    Console.Write("Lista " + (i + 1) + ": ");
    Console.WriteLine(string.Join("->", listas[i]));
}

Console.WriteLine("\nResultado de mezclar las listas anteriores:");
int[] resultado = MezclarListas(listas);
Console.WriteLine(string.Join("->", resultado));

int[] MezclarListas(int[][] listas)
{
    // Crear un min-heap para almacenar (valor, índice de arreglo, índice del elemento dentro del arreglo)
    // Agregando el primer elemento de cada arreglo al heap debido a que están ordenados
    PriorityQueue<(int val, int arrInd, int elemInd), int> heap = new PriorityQueue<(int val, int arrInd, int elemInd), int>();

    for (int i = 0; i < listas.Length; i++)
    {
        if (listas[i].Length > 0)
        {
            heap.Enqueue((listas[i][0], i, 0), listas[i][0]);
        }
    }

    List<int> result = new List<int>();

    // Mientras el heap no esté vacío, extraer el menor elemento
    // Y si hay más elementos en el mismo arreglo, agregar el siguiente al heap.
    while (heap.Count > 0)
    {
        var (val, arrInd, elemInd) = heap.Dequeue();
        result.Add(val);  // Añadir el valor al resultado.

        if (elemInd + 1 < listas[arrInd].Length)
        {
            heap.Enqueue((listas[arrInd][elemInd + 1], arrInd, elemInd + 1), listas[arrInd][elemInd + 1]);
        }
    }

    return result.ToArray();
}
