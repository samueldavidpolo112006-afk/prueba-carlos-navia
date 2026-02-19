using System;

class Program
{
    static void Main()
    {
        // 1. Declarar variables
        int width = 7;
        int height = 5;

        // 2. Calcular área
        int area = width * height;

        // 3. Calcular perímetro
        int perimeter = 2 * width + 2 * height;

        // 4. Incrementar width en 3 unidades
        width += 3;

        // 5. Decrementar height en 2 unidades
        height -= 2;

        // 6. Recalcular área y perímetro
        area = width * height;
        perimeter = 2 * width + 2 * height;

        // 7. Mostrar resultados finales
        Console.WriteLine("Valores finales:");
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);
    }
}

