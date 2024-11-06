using System;

// Ejemplo de prueba
int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

int maximaAgua = MaximaCantidadAgua(height);

public static int MaximaCantidadAgua(int[] alturas){
    int izquierda = 0;               // Puntero izquierdo
    int derecha = alturas.Length - 1; // Puntero derecho
    int maxArea = 0;                 // Máxima área encontrada

    while (izquierda < derecha){
        // Calcular el área actual
        int ancho = derecha - izquierda;
        int alturaActual = Math.Min(alturas[izquierda], alturas[derecha]);
        int areaActual = ancho * alturaActual;

        // Actualizar el área máxima si es mayor que la anterior
        maxArea = Math.Max(maxArea, areaActual);

        // Mover el puntero que apunta a la altura menor
        if (alturas[izquierda] < alturas[derecha]){
            izquierda++;
        }
        else{
            derecha--;
        }
    }

    return maxArea;
}

Console.WriteLine("La máxima cantidad de agua que se puede contener es: " + maximaAgua);
