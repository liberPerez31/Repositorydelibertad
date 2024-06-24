using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una lista de palabras aleatorias
        List<string> palabras = new List<string>
        {
            "manzana",
            "perro",
            "computadora",
            "libro",
            "playa"
        };

        // Crear un diccionario para asociar palabras con definiciones
        Dictionary<string, string> definiciones = new Dictionary<string, string>
        {
            { "manzana", "Fruta redonda y jugosa" },
            { "perro", "Animal doméstico que ladra" },
            { "computadora", "Dispositivo electrónico para procesar información" },
            { "libro", "Conjunto de hojas impresas encuadernadas" },
            { "playa", "Zona de arena junto al mar" }
        };

        // Elegir una palabra al azar
        Random rand = new Random();
        int indiceAleatorio = rand.Next(palabras.Count);
        string palabraSeleccionada = palabras[indiceAleatorio];

        // Mostrar la definición de la palabra
        Console.WriteLine($"Adivina la definición de la palabra: {palabraSeleccionada}");
        string respuestaUsuario = Console.ReadLine();

        // Verificar si la respuesta del usuario es correcta
        if (definiciones.TryGetValue(palabraSeleccionada, out string definicionCorrecta))
        {
            if (respuestaUsuario.ToLower() == definicionCorrecta.ToLower())
            {
                Console.WriteLine("¡Correcto! ¡Has adivinado la definición correctamente!");
            }
            else
            {
                Console.WriteLine($"Incorrecto. La definición correcta es: {definicionCorrecta}");
            }
        }
        else
        {
            Console.WriteLine("No se encontró una definición para la palabra seleccionada.");
        }
    }
}
