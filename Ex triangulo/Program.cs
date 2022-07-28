float val1, val2, val3;

Console.WriteLine("Digite o 1º valor do triangulo: ");
val1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o 2º valor do triangulo");
val2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o 3ºvalor do triangulo");
val3 = float.Parse(Console.ReadLine());

Console.Clear();

if((val1 + val2) < val3 || (val3 + val1) < val2 || (val2 + val3) < val1) 
{
    Console.WriteLine("Não é um triangulo");
}
else
{
    Console.WriteLine();
    if(val1 == val2 && val3 == val1)
    {
        Console.WriteLine("Triangulo Equilátero");
    } else if(val1 == val2 || val3 == val2 || val3 == val1)
    {
        Console.WriteLine("Triangulo Isósceles");
    } else
    {
        Console.WriteLine("Triangulo Escaleno");
    }
}

