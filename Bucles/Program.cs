//Bucles

int i = 0;

Console.WriteLine("WHILE...");
while (i <= 10) 
{
    Console.WriteLine($"Valor: {i}");
    i++;
}

Console.WriteLine("FOR...");
for (i=0;i<=10; i++)
{
    Console.WriteLine($"Valor: {i}");
}

Console.WriteLine("DO...");
i = 0;
do
{
    Console.WriteLine($"Valor: {i}");
    i++;
} while (i <= 10);

Console.WriteLine("FOR EACH...");
var names = new List<string> { "Andres", "Monica", "Erika" };
foreach (string nombre in names)
{
    Console.WriteLine($"Nombre: {nombre}");
}

Console.WriteLine("ARRAY...");
int[] arr = new int[3];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;
foreach (int item in arr)
{
    Console.WriteLine($"Valor: {item}");
}

