static void Fatorial(byte n) 
{ 
    long fat = 1;
    if (n == 0)
        fat = 0;
    else
        for (int i = 1; i <= n; i++)
            fat *= i;
    Console.WriteLine("Fatorial de {0} = {1}", n, fat);
}

Console.Title = "Programa Fatorial";
Console.WriteLine("Digite um valor para fatoriar");
byte x = byte.Parse(Console.ReadLine());
Console.WriteLine();

Fatorial(x);