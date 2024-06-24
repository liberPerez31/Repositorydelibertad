using System;

namespace RegistroEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir la cantidad de estudiantes
            const int cantidadEstudiantes = 3;

            // Crear una lista para almacenar los datos de los estudiantes
            string[,] estudiantes = new string[cantidadEstudiantes, 2]; // [número de estudiantes, número de atributos]

            // Llenar la lista con datos de los estudiantes
            estudiantes[0, 0] = "Juan"; 
            estudiantes[0, 1] = "85"; 

            estudiantes[1, 0] = "María"; 
            estudiantes[1, 1] = "92"; 

            estudiantes[2, 0] = "Pedro"; 
            estudiantes[2, 1] = "78"; 

            Console.WriteLine("Datos de los estudiantes:");
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                string nombre = estudiantes[i, 0];
                string notaFinal = estudiantes[i, 1];
                Console.WriteLine($"Estudiante {i + 1}: {nombre}, Nota final: {notaFinal}");
            }

            Console.ReadLine();
        }
    }
}