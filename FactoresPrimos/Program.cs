System.Console.WriteLine("Ingresa el numero a descomponer:");
int num = int.Parse(System.Console.ReadLine());
int[] factores = new int[10];
int indice=0;
int divisor = 2;

while (divisor<= num)
{
    if ((num % divisor) == 0)
    {
        factores[indice] = divisor;
        num = num / divisor;
        indice++;
        continue;
    }
    divisor++;
}

int i = 0;
while (i < indice)
{
    System.Console.WriteLine(factores[i]);
    i++;
}
