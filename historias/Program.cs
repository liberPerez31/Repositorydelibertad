using System;

class Program
{
    static void Main()
    {
        // Arreglos con posibles personajes, lugares y eventos
        string[] personajes = { "el valiente caballero", "la astuta bruja", "el explorador espacial", "la princesa encantada" };
        string[] lugares = { "en un antiguo castillo", "en un bosque misterioso", "en un planeta lejano", "bajo el mar" };
        string[] eventos = { "descubrió un tesoro escondido", "luchó contra un dragón feroz", "resolvió un enigma ancestral", "se enamoró perdidamente" };

        // Generar índices aleatorios para seleccionar elementos de los arreglos
        Random random = new Random();
        int indicePersonaje = random.Next(personajes.Length);
        int indiceLugar = random.Next(lugares.Length);
        int indiceEvento = random.Next(eventos.Length);

        // Crear la historia mezclando los elementos seleccionados
        string historia = $"{personajes[indicePersonaje]} se encontraba {lugares[indiceLugar]} cuando {eventos[indiceEvento]}.";

        Console.WriteLine(historia);
    }
}