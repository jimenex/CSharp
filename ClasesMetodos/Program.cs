//1. Origen de datos
using System;

int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] nombres = new string[5] { "Alyson", "Andres", "Erika", "Monica", "Samia" };

//Obtener Datros LINQ.
var pares = from numero in numeros where (numero % 2) == 0 select numero;
var impares = from numero in numeros where (numero % 2) != 0 select numero;
var nums = from numero in numeros where (numero >5 && numero <= 8) select numero;
var nombs = from nombre in nombres where (nombre.Length == 5) select nombre;

//Clases Anonimas
var vehiculo = new {Marca = "Ford", Ano = 2021};
var res = 1 << 2;
Console.WriteLine($"Res: {res}");

//Utilizar en el sistema.
foreach (var num in pares)
{
    Console.WriteLine($"NumerPar: {num}");
}

foreach (var num in impares)
{
    Console.WriteLine($"NumerImPar: {num}");
}

foreach (var nom in nombs)
{
    Console.WriteLine($"Nombre: {nom}");
}

