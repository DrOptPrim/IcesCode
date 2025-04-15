using System;

class Program
{
    static void Main()
    {
        string nombre;

        // Pedir nombre del estudiante (no debe estar vacío)
        do
        {
            Console.Write("Nombre del estudiante: ");
            nombre = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(nombre));

        int cantidadNotas;

        // Pedir cuántas notas va a ingresar (entre 1 y 5)
        do
        {
            Console.Write("Cantidad de calificaciones (1 a 5): ");
        } while (!int.TryParse(Console.ReadLine(), out cantidadNotas) || cantidadNotas < 1 || cantidadNotas > 5);

        double suma = 0;

        // Ingresar las calificaciones y sumarlas
        for (int i = 1; i <= cantidadNotas; i++)
        {
            double nota;
            do
            {
                Console.Write($"Nota #{i} (1 a 10): ");
            } while (!double.TryParse(Console.ReadLine(), out nota) || nota < 1 || nota > 10);

            suma += nota;
        }

        double promedio = suma / cantidadNotas;

        Console.WriteLine();
        Console.WriteLine($"Estudiante: {nombre}");
        Console.WriteLine($"Promedio: {promedio:F2}");

        // Clasificación según el promedio
        if (promedio >= 9)
            Console.WriteLine("Clasificación: Excelente");
        else if (promedio >= 7)
            Console.WriteLine("Clasificación: Bueno");
        else if (promedio >= 6)
            Console.WriteLine("Clasificación: Regular");
        else
            Console.WriteLine("Clasificación: Reprobado");
    }
}
