using System;

class PromedioEstudiantes
{
    static void Main()
    {
        string[] asignaturas = new string[3];
        double[,] notas = new double[4, 3];

        // Pedir nombres de asignaturas
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Ingrese el nombre de la asignatura " + (i + 1) + ": ");
            asignaturas[i] = Console.ReadLine();
        }

        // Pedir notas de los estudiantes
        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine("\nNotas para la asignatura: " + asignaturas[j]);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese la nota del estudiante " + (i + 1) + ": ");
                notas[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Promedio de cada estudiante
        Console.WriteLine("\nPromedio de cada estudiante:");
        for (int i = 0; i < 4; i++)
        {
            double suma = 0;

            for (int j = 0; j < 3; j++)
            {
                suma += notas[i, j];
            }

            Console.WriteLine("Estudiante " + (i + 1) + ": " + (suma / 3));
        }

        // Promedio de cada asignatura
        Console.WriteLine("\nPromedio de cada asignatura:");
        for (int j = 0; j < 3; j++)
        {
            double suma = 0;

            for (int i = 0; i < 4; i++)
            {
                suma += notas[i, j];
            }

            Console.WriteLine(asignaturas[j] + ": " + (suma / 4));
        }
    }
}
