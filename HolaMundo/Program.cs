// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce tu nombre:");
string? nombre =  Console.ReadLine();
Console.WriteLine("Introduce tu edad:");
int? edad = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce tu ciudad:");
string? ciudad = Console.ReadLine();
Console.WriteLine("Hello! "+ nombre);
Console.WriteLine($"Hola: {nombre} su edad es: {edad} su ciudad es: {ciudad}");