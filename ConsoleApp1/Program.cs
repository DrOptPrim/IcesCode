using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Informacion estudiante ");

        string nombre;
        do
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine(" El nombre es obligatorio, intente nuevamente ");
            }
        } while (string.IsNullOrWhiteSpace(nombre));

        int cantidadNotas;
        do
        {
            Console.Write(" Numweros de calificaiones que va a ingresar, (1 a 5): ");
        } while (!int.TryParse(Console.ReadLine(), out cantidadNotas) || cantidadNotas < 1 || cantidadNotas > 5);

        double suma = 0;
        int notasValidas = 0;

        for (int i = 1; i <= cantidadNotas; i++)
        {
            double nota;
            do
            {
                Console.Write($"Ingrese la calificación #{i} (1 a 10): ");
            } while (!double.TryParse(Console.ReadLine(), out nota) || nota < 1 || nota > 10);

            suma += nota;
            notasValidas++;
        }

        double promedio = suma / notasValidas;

        Console.WriteLine($"Estudiante: {nombre}");
        Console.WriteLine($"Promedio: {promedio:F2}");

        if (promedio >= 9)
        {
            Console.WriteLine("Excelente");
        }
        else if (promedio >= 7)
        {
            Console.WriteLine("Bueno");
        }
        else if (promedio >= 6)
        {
            Console.WriteLine("Regular");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}