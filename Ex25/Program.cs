static long Fatorial(byte n)
{
    long fat = 1;
    if (n == 0)
        fat = 0;
    else
        for (int i = 1; i <= n; i++)
            fat *= i;
    return fat;
}

byte x;
long r;

Console.Title = "Programa Fatorial";
Console.Write("Entre um valor numerico: ");
x = byte.Parse(Console.ReadLine());
Console.WriteLine();
r = Fatorial(x);

Console.WriteLine("Fatorial de {0} = {1}",x,r);
Console.WriteLine();