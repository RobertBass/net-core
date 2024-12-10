using Humanizer;

Console.WriteLine("Por favor ingresa tu nombre: ");
var nombre = Console.ReadLine();
Console.WriteLine("Ingresa tu edad: ");
var edad = int.Parse(Console.ReadLine());
Console.WriteLine($"Hola, mi nombre es {nombre} y tengo {edad.ToWords()} anios");

