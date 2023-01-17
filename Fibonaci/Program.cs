Console.WriteLine("Ingresa el numero:");
int n = int.Parse(Console.ReadLine());
int n1 = 1;
int n2 = 1;

for (int i = 0; i < n; i++)
{   
    int tmp = n1;
    n1 = n2;
    n2 = tmp + n1;
    Console.WriteLine(n1);
}