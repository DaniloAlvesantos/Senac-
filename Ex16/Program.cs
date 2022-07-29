long Fat = 1, n, i;
Console.WriteLine("Informe um valor: ");
n = long.Parse(Console.ReadLine());

i = 1;

do
{
    Fat = Fat * i;
    i = i + 1;
}
while(i <= n);

Console.WriteLine();
Console.WriteLine("Fatorial de {0} = {1};", n, Fat);