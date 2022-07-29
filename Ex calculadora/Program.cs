int opc;
float n1, n2, r;

Console.WriteLine("Digite o 1° valor: ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o 2° valor: ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("[1]..........Adição");
Console.WriteLine("[2].......Subtração");
Console.WriteLine("[3]...Multiplicação");
Console.WriteLine("[4].........Divisão");
Console.WriteLine();
Console.WriteLine("Escolha uma opção --> ");
opc = int.Parse(Console.ReadLine());

if( opc == 1)
{
    r = n1 + n2;
    Console.WriteLine("Resultado = " + r);
}
if(opc == 2)
{
    r = n1 - n2;
    Console.WriteLine("Resultado = " + r);
}
if( opc == 3)
{
    r = n1 * n2;
    Console.WriteLine("Resultado = " + r);
}
if(opc == 4)
{
    if (n2 == 0)
        Console.WriteLine("ERRO !! Não é possivel dividir por 0");
    else
    {
        r = n1 / n2;
        Console.WriteLine("Resultado = " + r);
    }
}

