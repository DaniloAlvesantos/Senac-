long Fat = 1, n, i;
Console.WriteLine("Informe um valor: ");
n = long.Parse(Console.ReadLine());

i = 1;

for(i = 1; i <= n; i++)
    Fat *= i;

Console.WriteLine();
Console.WriteLine("Fatorial de {0} = {1};", n, Fat);