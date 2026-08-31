using EjemploSustitucionLiskov;

Console.WriteLine("Iniciando programa");

Loro miLoro = new Loro();
miLoro.Edad = 3;
miLoro.Peso = 0.9;

Pinguino miPinguino = new Pinguino();
miPinguino.Edad = 5;
miPinguino.Peso = 12.5;

Avestruz miAvestruz = new Avestruz();
miAvestruz.Edad = 8;
miAvestruz.Peso = 95;

List<Ave> aves =
[
    miLoro,
    miPinguino,
    miAvestruz
];

Console.WriteLine("\nSe han añadido 3 aves a la lista.\n");
Console.WriteLine("A continuación se imprimirán sus caracteristicas.");
Console.WriteLine();

foreach (Ave ave in aves)
{
    Console.WriteLine($"Tipo: {ave.TipoDeAve()}");
    Console.WriteLine($"Edad: {ave.Edad} años");
    Console.WriteLine($"Peso: {ave.Peso} kg");
    Console.WriteLine();
}

Console.WriteLine("\nCada ave puede moverse de forma única. Cada clase tiene una función única para esta tarea.\n");

miLoro.Volar();
miPinguino.Nadar();
miAvestruz.correr();

Console.WriteLine("\nEl uso de la sustitución de Liskov nos permite hacer que cualquier instancia de Ave pueda reemplazar " +
    "\n" + "a un objeto Ave en todas sus funciones, además de añadirle métodos únicos a cada una.");

// Este es un comentario.
