using System;

class Program
{
    static void Main()
    {
        // Reto Tipos de Datos

        string producto = "Celular";
        int cantidad = 2;
        double precioUnitario = 1800.75;
        bool disponible = true;

        double total = cantidad * precioUnitario;

        Console.WriteLine("=== RETO TIPOS DE DATOS ===");
        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine($"Precio unitario: {precioUnitario}");
        Console.WriteLine($"Disponible: {disponible}");
        Console.WriteLine($"Total a pagar: {total}");
    }
}
